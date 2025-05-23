using Coravel.Invocable;
using PatientSystem.Data;

namespace PatientSystem
{
    public class MyInvocable : IInvocable
    {
        private readonly ILogger<MyInvocable> _logger;
        private ApplicationDbContext _context;
        public MyInvocable(ApplicationDbContext context, ILogger<MyInvocable> logger)
        {
            this._context = context;
            this._logger = logger;
        }

        public Task Invoke()
        {
            // Your code here
            _logger.LogInformation("MyInvocable is running!");
            return Task.CompletedTask;
        }
    }
}
