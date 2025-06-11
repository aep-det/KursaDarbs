using Coravel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using Serilog;
using System.Security.Cryptography.Pkcs;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();

builder.Services.AddScheduler();
builder.Services.AddTransient<PatientSystem.MyInvocable>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    await context.Database.EnsureCreatedAsync();
    //await context.Database.MigrateAsync();

    var rm = services.GetRequiredService<RoleManager<IdentityRole>>();

    if (!rm.Roles.Any())
    {
        DbInitializer.Initialize(context);

        string[] roleNames = { "Admin", "Patient", "Professional" };
        foreach (var roleName in roleNames)
        {
            var roleExist = await rm.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await rm.CreateAsync(new IdentityRole(roleName));
            }
        }

        // admin user
        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        var adminEmail = "admin@example.com";
        var adminPassword = "Admin@123";

        var adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail };
        var userExist = await userManager.FindByEmailAsync(adminEmail);

        if (userExist == null)
        {
            await userManager.CreateAsync(adminUser, adminPassword);
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }

        #region Create default roles and users for testing purposes

        var defaultPassword = "Test123!"; // Or use a secure one

        foreach (var patient in context.Patients.ToList())
        {
            var user = new IdentityUser { UserName = patient.Email, Email = patient.Email };
            var result = await userManager.CreateAsync(user, defaultPassword);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Patient");
            }
        }

        foreach (var professional in context.Professionals.ToList())
        {
            var user = new IdentityUser { UserName = professional.Email, Email = professional.Email };
            var result = await userManager.CreateAsync(user, defaultPassword);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Professional");
            }
        }

        #endregion

    }

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSerilogRequestLogging();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Services.UseScheduler(scheduler =>
{
    scheduler.Schedule<PatientSystem.MyInvocable>()
        .EveryMinute();
        //.EveryFiveMinutes();
        //.PreventOverlapping();
});

app.Run();
