namespace PatientSystem.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {

            if (context.Patients.Any())
            {
                return;   // DB has been seeded
            }
            #region MyDataGen
            var patients = new Patient[]
{
    new Patient
    {
        Name = "Noah Smith",
        Email = "patient1@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-02-11"),
    },
    new Patient
    {
        Name = "Ava Brown",
        Email = "patient2@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-10-29"),
    },
    new Patient
    {
        Name = "Liam Smith",
        Email = "patient3@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1995-05-10"),
    },
    new Patient
    {
        Name = "Mason Wilson",
        Email = "patient4@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1980-07-28"),
    },
    new Patient
    {
        Name = "Mason Brown",
        Email = "patient5@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1972-04-05"),
    },
    new Patient
    {
        Name = "Liam Taylor",
        Email = "patient6@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1975-06-25"),
    },
    new Patient
    {
        Name = "Ava Miller",
        Email = "patient7@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1982-07-24"),
    },
    new Patient
    {
        Name = "Mason Smith",
        Email = "patient8@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1986-04-03"),
    },
    new Patient
    {
        Name = "Liam Moore",
        Email = "patient9@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1993-04-25"),
    },
    new Patient
    {
        Name = "Noah Brown",
        Email = "patient10@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1981-10-24"),
    },
    new Patient
    {
        Name = "Ava Jones",
        Email = "patient11@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1979-06-10"),
    },
    new Patient
    {
        Name = "Liam Williams",
        Email = "patient12@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1977-06-22"),
    },
    new Patient
    {
        Name = "Liam Jones",
        Email = "patient13@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2001-10-29"),
    },
    new Patient
    {
        Name = "Emma Johnson",
        Email = "patient14@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1992-01-03"),
    },
    new Patient
    {
        Name = "Lucas Davis",
        Email = "patient15@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1970-12-13"),
    },
    new Patient
    {
        Name = "Lucas Smith",
        Email = "patient16@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-07-18"),
    },
    new Patient
    {
        Name = "Mason Williams",
        Email = "patient17@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1978-02-23"),
    },
    new Patient
    {
        Name = "Ava Miller",
        Email = "patient18@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1977-04-14"),
    },
    new Patient
    {
        Name = "John Miller",
        Email = "patient19@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1994-09-23"),
    },
    new Patient
    {
        Name = "Olivia Davis",
        Email = "patient20@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1972-03-23"),
    },
    new Patient
    {
        Name = "Olivia Wilson",
        Email = "patient21@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1994-06-27"),
    },
    new Patient
    {
        Name = "Olivia Smith",
        Email = "patient22@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1983-03-24"),
    },
    new Patient
    {
        Name = "Noah Davis",
        Email = "patient23@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1980-06-17"),
    },
    new Patient
    {
        Name = "Sophia Moore",
        Email = "patient24@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1986-10-24"),
    },
    new Patient
    {
        Name = "Mason Taylor",
        Email = "patient25@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-03-28"),
    },
    new Patient
    {
        Name = "Mason Williams",
        Email = "patient26@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1984-01-09"),
    },
    new Patient
    {
        Name = "Mason Jones",
        Email = "patient27@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1999-08-05"),
    },
    new Patient
    {
        Name = "Olivia Brown",
        Email = "patient28@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-04-18"),
    },
    new Patient
    {
        Name = "Ava Johnson",
        Email = "patient29@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1995-03-29"),
    },
    new Patient
    {
        Name = "Sophia Jones",
        Email = "patient30@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1978-04-16"),
    },
    new Patient
    {
        Name = "Olivia Moore",
        Email = "patient31@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1970-05-12"),
    },
    new Patient
    {
        Name = "Liam Taylor",
        Email = "patient32@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1974-02-15"),
    },
    new Patient
    {
        Name = "Lucas Smith",
        Email = "patient33@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2002-07-24"),
    },
    new Patient
    {
        Name = "Isabella Moore",
        Email = "patient34@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1977-08-20"),
    },
    new Patient
    {
        Name = "Sophia Wilson",
        Email = "patient35@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2005-09-19"),
    },
    new Patient
    {
        Name = "Sophia Johnson",
        Email = "patient36@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1975-12-05"),
    },
    new Patient
    {
        Name = "Sophia Wilson",
        Email = "patient37@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2002-07-02"),
    },
    new Patient
    {
        Name = "Olivia Miller",
        Email = "patient38@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1974-04-17"),
    },
    new Patient
    {
        Name = "Ava Johnson",
        Email = "patient39@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1985-03-21"),
    },
    new Patient
    {
        Name = "Lucas Johnson",
        Email = "patient40@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1981-08-20"),
    },
    new Patient
    {
        Name = "Ava Taylor",
        Email = "patient41@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2005-01-22"),
    },
    new Patient
    {
        Name = "Olivia Davis",
        Email = "patient42@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1983-09-14"),
    },
    new Patient
    {
        Name = "Liam Taylor",
        Email = "patient43@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1992-11-03"),
    },
    new Patient
    {
        Name = "Lucas Johnson",
        Email = "patient44@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1991-10-05"),
    },
    new Patient
    {
        Name = "John Miller",
        Email = "patient45@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-01-22"),
    },
    new Patient
    {
        Name = "Noah Brown",
        Email = "patient46@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2001-05-22"),
    },
    new Patient
    {
        Name = "Isabella Johnson",
        Email = "patient47@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1981-07-26"),
    },
    new Patient
    {
        Name = "John Taylor",
        Email = "patient48@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1973-10-10"),
    },
    new Patient
    {
        Name = "Olivia Wilson",
        Email = "patient49@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1973-02-06"),
    },
    new Patient
    {
        Name = "Isabella Wilson",
        Email = "patient50@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-02-18"),
    },
    new Patient
    {
        Name = "Ava Moore",
        Email = "patient51@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1987-03-13"),
    },
    new Patient
    {
        Name = "Isabella Johnson",
        Email = "patient52@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1998-11-27"),
    },
    new Patient
    {
        Name = "Emma Wilson",
        Email = "patient53@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1987-05-17"),
    },
    new Patient
    {
        Name = "Noah Smith",
        Email = "patient54@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1973-11-27"),
    },
    new Patient
    {
        Name = "Liam Brown",
        Email = "patient55@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1994-03-13"),
    },
    new Patient
    {
        Name = "Ava Miller",
        Email = "patient56@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1972-11-04"),
    },
    new Patient
    {
        Name = "Mason Moore",
        Email = "patient57@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1998-07-25"),
    },
    new Patient
    {
        Name = "John Miller",
        Email = "patient58@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-06-25"),
    },
    new Patient
    {
        Name = "Lucas Smith",
        Email = "patient59@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1993-07-02"),
    },
    new Patient
    {
        Name = "Lucas Jones",
        Email = "patient60@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-11-25"),
    },
    new Patient
    {
        Name = "Lucas Williams",
        Email = "patient61@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1972-01-09"),
    },
    new Patient
    {
        Name = "Isabella Smith",
        Email = "patient62@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2004-09-09"),
    },
    new Patient
    {
        Name = "Olivia Wilson",
        Email = "patient63@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1999-07-12"),
    },
    new Patient
    {
        Name = "Ava Jones",
        Email = "patient64@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1977-07-16"),
    },
    new Patient
    {
        Name = "Ava Williams",
        Email = "patient65@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1975-02-12"),
    },
    new Patient
    {
        Name = "Noah Williams",
        Email = "patient66@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1972-03-23"),
    },
    new Patient
    {
        Name = "Noah Davis",
        Email = "patient67@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1997-07-07"),
    },
    new Patient
    {
        Name = "Olivia Jones",
        Email = "patient68@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1986-09-14"),
    },
    new Patient
    {
        Name = "Noah Smith",
        Email = "patient69@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1975-08-15"),
    },
    new Patient
    {
        Name = "Ava Williams",
        Email = "patient70@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1982-11-29"),
    },
    new Patient
    {
        Name = "Ava Wilson",
        Email = "patient71@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1979-10-22"),
    },
    new Patient
    {
        Name = "Liam Davis",
        Email = "patient72@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1974-07-25"),
    },
    new Patient
    {
        Name = "Isabella Brown",
        Email = "patient73@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2003-08-03"),
    },
    new Patient
    {
        Name = "John Johnson",
        Email = "patient74@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2002-07-05"),
    },
    new Patient
    {
        Name = "Noah Davis",
        Email = "patient75@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2003-06-03"),
    },
    new Patient
    {
        Name = "John Miller",
        Email = "patient76@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1976-06-01"),
    },
    new Patient
    {
        Name = "Liam Jones",
        Email = "patient77@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2005-02-15"),
    },
    new Patient
    {
        Name = "Emma Miller",
        Email = "patient78@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1994-01-02"),
    },
    new Patient
    {
        Name = "Liam Taylor",
        Email = "patient79@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-12-23"),
    },
    new Patient
    {
        Name = "Noah Johnson",
        Email = "patient80@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1999-11-02"),
    },
    new Patient
    {
        Name = "Emma Johnson",
        Email = "patient81@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1982-09-29"),
    },
    new Patient
    {
        Name = "Emma Johnson",
        Email = "patient82@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1989-06-25"),
    },
    new Patient
    {
        Name = "Olivia Williams",
        Email = "patient83@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1976-03-01"),
    },
    new Patient
    {
        Name = "Lucas Brown",
        Email = "patient84@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1998-07-16"),
    },
    new Patient
    {
        Name = "Olivia Davis",
        Email = "patient85@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1997-05-03"),
    },
    new Patient
    {
        Name = "Isabella Wilson",
        Email = "patient86@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-07-21"),
    },
    new Patient
    {
        Name = "Lucas Johnson",
        Email = "patient87@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1985-07-12"),
    },
    new Patient
    {
        Name = "Lucas Taylor",
        Email = "patient88@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1998-03-15"),
    },
    new Patient
    {
        Name = "Liam Johnson",
        Email = "patient89@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1971-08-11"),
    },
    new Patient
    {
        Name = "Sophia Jones",
        Email = "patient90@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1976-09-04"),
    },
    new Patient
    {
        Name = "Emma Williams",
        Email = "patient91@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1996-05-23"),
    },
    new Patient
    {
        Name = "Ava Williams",
        Email = "patient92@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1990-09-08"),
    },
    new Patient
    {
        Name = "Sophia Davis",
        Email = "patient93@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1998-05-04"),
    },
    new Patient
    {
        Name = "John Brown",
        Email = "patient94@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1979-09-03"),
    },
    new Patient
    {
        Name = "Olivia Taylor",
        Email = "patient95@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1971-12-26"),
    },
    new Patient
    {
        Name = "Noah Smith",
        Email = "patient96@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1989-06-22"),
    },
    new Patient
    {
        Name = "Mason Davis",
        Email = "patient97@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("2003-03-11"),
    },
    new Patient
    {
        Name = "Mason Davis",
        Email = "patient98@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1974-03-30"),
    },
    new Patient
    {
        Name = "Isabella Davis",
        Email = "patient99@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1983-03-20"),
    },
    new Patient
    {
        Name = "John Moore",
        Email = "patient100@example.com",
        PasswordHash = "hashed123",
        DateOfBirth = DateTime.Parse("1997-09-25"),
    },
};
            context.Patients.AddRange(patients);
            context.SaveChanges();

            var professionals = new Professional[]
            {
    new Professional
    {
        Name = "Dr. Emma Taylor",
        Email = "professional1@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Wilson",
        Email = "professional2@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Emma Johnson",
        Email = "professional3@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Mason Moore",
        Email = "professional4@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Emma Brown",
        Email = "professional5@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Ava Johnson",
        Email = "professional6@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Noah Davis",
        Email = "professional7@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Olivia Wilson",
        Email = "professional8@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Isabella Wilson",
        Email = "professional9@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Olivia Davis",
        Email = "professional10@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Williams",
        Email = "professional11@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Isabella Williams",
        Email = "professional12@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Isabella Williams",
        Email = "professional13@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Isabella Johnson",
        Email = "professional14@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Lucas Miller",
        Email = "professional15@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Lucas Smith",
        Email = "professional16@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Mason Williams",
        Email = "professional17@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Ava Davis",
        Email = "professional18@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Moore",
        Email = "professional19@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Lucas Miller",
        Email = "professional20@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Liam Brown",
        Email = "professional21@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Olivia Taylor",
        Email = "professional22@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. John Jones",
        Email = "professional23@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Mason Smith",
        Email = "professional24@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Mason Brown",
        Email = "professional25@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Lucas Wilson",
        Email = "professional26@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Lucas Moore",
        Email = "professional27@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Lucas Brown",
        Email = "professional28@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Mason Wilson",
        Email = "professional29@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Ava Brown",
        Email = "professional30@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Olivia Jones",
        Email = "professional31@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Mason Taylor",
        Email = "professional32@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Isabella Johnson",
        Email = "professional33@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. John Taylor",
        Email = "professional34@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Johnson",
        Email = "professional35@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Mason Davis",
        Email = "professional36@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Ava Brown",
        Email = "professional37@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Isabella Davis",
        Email = "professional38@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Isabella Miller",
        Email = "professional39@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Emma Miller",
        Email = "professional40@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Taylor",
        Email = "professional41@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Ava Williams",
        Email = "professional42@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Ava Miller",
        Email = "professional43@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Liam Johnson",
        Email = "professional44@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Noah Wilson",
        Email = "professional45@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Sophia Moore",
        Email = "professional46@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Isabella Moore",
        Email = "professional47@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Sophia Brown",
        Email = "professional48@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Isabella Taylor",
        Email = "professional49@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Noah Williams",
        Email = "professional50@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Liam Wilson",
        Email = "professional51@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Sophia Jones",
        Email = "professional52@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Liam Moore",
        Email = "professional53@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Isabella Davis",
        Email = "professional54@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. John Johnson",
        Email = "professional55@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Isabella Taylor",
        Email = "professional56@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Noah Johnson",
        Email = "professional57@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Emma Wilson",
        Email = "professional58@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Williams",
        Email = "professional59@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Ava Jones",
        Email = "professional60@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Ava Moore",
        Email = "professional61@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Noah Davis",
        Email = "professional62@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Liam Jones",
        Email = "professional63@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. John Wilson",
        Email = "professional64@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Mason Miller",
        Email = "professional65@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Sophia Williams",
        Email = "professional66@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Wilson",
        Email = "professional67@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Isabella Miller",
        Email = "professional68@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. John Davis",
        Email = "professional69@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Lucas Wilson",
        Email = "professional70@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Liam Williams",
        Email = "professional71@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. John Williams",
        Email = "professional72@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Mason Wilson",
        Email = "professional73@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Liam Smith",
        Email = "professional74@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Liam Brown",
        Email = "professional75@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Jones",
        Email = "professional76@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Davis",
        Email = "professional77@example.com",
        PasswordHash = "hashed456",
        Specialization = "Cardiology",
    },
    new Professional
    {
        Name = "Dr. Emma Brown",
        Email = "professional78@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Olivia Smith",
        Email = "professional79@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Noah Smith",
        Email = "professional80@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Lucas Jones",
        Email = "professional81@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Mason Moore",
        Email = "professional82@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Miller",
        Email = "professional83@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Liam Jones",
        Email = "professional84@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Isabella Brown",
        Email = "professional85@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Wilson",
        Email = "professional86@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Emma Johnson",
        Email = "professional87@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Isabella Wilson",
        Email = "professional88@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. Lucas Johnson",
        Email = "professional89@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Mason Jones",
        Email = "professional90@example.com",
        PasswordHash = "hashed456",
        Specialization = "Dermatology",
    },
    new Professional
    {
        Name = "Dr. John Moore",
        Email = "professional91@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Emma Jones",
        Email = "professional92@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Olivia Jones",
        Email = "professional93@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Noah Smith",
        Email = "professional94@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Isabella Moore",
        Email = "professional95@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Sophia Davis",
        Email = "professional96@example.com",
        PasswordHash = "hashed456",
        Specialization = "General Practice",
    },
    new Professional
    {
        Name = "Dr. Sophia Williams",
        Email = "professional97@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
    new Professional
    {
        Name = "Dr. Mason Brown",
        Email = "professional98@example.com",
        PasswordHash = "hashed456",
        Specialization = "Neurology",
    },
    new Professional
    {
        Name = "Dr. Lucas Williams",
        Email = "professional99@example.com",
        PasswordHash = "hashed456",
        Specialization = "Oncology",
    },
    new Professional
    {
        Name = "Dr. Sophia Davis",
        Email = "professional100@example.com",
        PasswordHash = "hashed456",
        Specialization = "Pediatrics",
    },
            };
            context.Professionals.AddRange(professionals);
            context.SaveChanges();

            var appointments = new Appointment[]
            {
    new Appointment
    {
        PatientId = 5,
        ProfessionalId = 61,
        Date = DateTime.Parse("2024-12-15"),
        Time = "8:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 81,
        ProfessionalId = 69,
        Date = DateTime.Parse("2024-06-28"),
        Time = "8:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 91,
        ProfessionalId = 66,
        Date = DateTime.Parse("2024-01-07"),
        Time = "17:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 99,
        ProfessionalId = 79,
        Date = DateTime.Parse("2023-06-19"),
        Time = "10:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 44,
        ProfessionalId = 67,
        Date = DateTime.Parse("2023-04-25"),
        Time = "9:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 41,
        ProfessionalId = 76,
        Date = DateTime.Parse("2023-05-03"),
        Time = "10:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 77,
        ProfessionalId = 92,
        Date = DateTime.Parse("2023-03-17"),
        Time = "12:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 96,
        ProfessionalId = 34,
        Date = DateTime.Parse("2024-05-08"),
        Time = "17:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 99,
        ProfessionalId = 21,
        Date = DateTime.Parse("2024-01-06"),
        Time = "13:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 94,
        ProfessionalId = 84,
        Date = DateTime.Parse("2023-05-12"),
        Time = "10:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 82,
        ProfessionalId = 50,
        Date = DateTime.Parse("2023-08-12"),
        Time = "10:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 21,
        ProfessionalId = 53,
        Date = DateTime.Parse("2023-03-11"),
        Time = "12:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 43,
        ProfessionalId = 84,
        Date = DateTime.Parse("2024-12-10"),
        Time = "16:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 20,
        ProfessionalId = 68,
        Date = DateTime.Parse("2023-01-01"),
        Time = "11:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 46,
        ProfessionalId = 52,
        Date = DateTime.Parse("2023-02-27"),
        Time = "11:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 58,
        ProfessionalId = 68,
        Date = DateTime.Parse("2023-03-01"),
        Time = "14:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 4,
        ProfessionalId = 30,
        Date = DateTime.Parse("2024-07-28"),
        Time = "9:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 13,
        ProfessionalId = 55,
        Date = DateTime.Parse("2023-03-21"),
        Time = "15:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 72,
        ProfessionalId = 97,
        Date = DateTime.Parse("2024-11-23"),
        Time = "17:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 92,
        ProfessionalId = 25,
        Date = DateTime.Parse("2024-08-08"),
        Time = "8:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 76,
        ProfessionalId = 18,
        Date = DateTime.Parse("2023-11-06"),
        Time = "14:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 92,
        ProfessionalId = 29,
        Date = DateTime.Parse("2023-09-09"),
        Time = "12:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 78,
        ProfessionalId = 34,
        Date = DateTime.Parse("2024-07-30"),
        Time = "11:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 51,
        ProfessionalId = 75,
        Date = DateTime.Parse("2024-07-21"),
        Time = "17:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 38,
        ProfessionalId = 42,
        Date = DateTime.Parse("2023-11-17"),
        Time = "12:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 83,
        ProfessionalId = 43,
        Date = DateTime.Parse("2024-08-21"),
        Time = "12:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 63,
        ProfessionalId = 59,
        Date = DateTime.Parse("2023-09-04"),
        Time = "14:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 28,
        ProfessionalId = 65,
        Date = DateTime.Parse("2023-11-01"),
        Time = "17:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 31,
        ProfessionalId = 46,
        Date = DateTime.Parse("2024-10-04"),
        Time = "8:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 65,
        ProfessionalId = 91,
        Date = DateTime.Parse("2023-01-30"),
        Time = "13:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 59,
        ProfessionalId = 98,
        Date = DateTime.Parse("2024-03-20"),
        Time = "15:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 70,
        ProfessionalId = 93,
        Date = DateTime.Parse("2024-03-04"),
        Time = "11:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 37,
        ProfessionalId = 85,
        Date = DateTime.Parse("2023-12-26"),
        Time = "9:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 47,
        ProfessionalId = 89,
        Date = DateTime.Parse("2023-12-14"),
        Time = "14:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 40,
        ProfessionalId = 31,
        Date = DateTime.Parse("2024-11-26"),
        Time = "14:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 62,
        ProfessionalId = 65,
        Date = DateTime.Parse("2024-12-29"),
        Time = "15:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 36,
        ProfessionalId = 90,
        Date = DateTime.Parse("2023-08-06"),
        Time = "10:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 74,
        ProfessionalId = 1,
        Date = DateTime.Parse("2023-03-07"),
        Time = "9:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 13,
        ProfessionalId = 89,
        Date = DateTime.Parse("2024-02-11"),
        Time = "15:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 13,
        ProfessionalId = 73,
        Date = DateTime.Parse("2024-09-15"),
        Time = "8:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 68,
        ProfessionalId = 3,
        Date = DateTime.Parse("2024-10-13"),
        Time = "10:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 4,
        ProfessionalId = 14,
        Date = DateTime.Parse("2023-04-25"),
        Time = "16:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 49,
        ProfessionalId = 73,
        Date = DateTime.Parse("2023-07-03"),
        Time = "16:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 32,
        ProfessionalId = 47,
        Date = DateTime.Parse("2023-11-29"),
        Time = "8:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 14,
        ProfessionalId = 35,
        Date = DateTime.Parse("2024-01-17"),
        Time = "15:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 49,
        ProfessionalId = 24,
        Date = DateTime.Parse("2023-11-23"),
        Time = "15:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 21,
        ProfessionalId = 63,
        Date = DateTime.Parse("2023-09-04"),
        Time = "16:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 13,
        ProfessionalId = 20,
        Date = DateTime.Parse("2023-08-09"),
        Time = "14:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 29,
        ProfessionalId = 2,
        Date = DateTime.Parse("2023-07-25"),
        Time = "12:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 82,
        ProfessionalId = 15,
        Date = DateTime.Parse("2024-10-04"),
        Time = "16:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 30,
        ProfessionalId = 16,
        Date = DateTime.Parse("2024-01-29"),
        Time = "17:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 51,
        ProfessionalId = 57,
        Date = DateTime.Parse("2024-08-06"),
        Time = "9:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 3,
        ProfessionalId = 45,
        Date = DateTime.Parse("2023-10-25"),
        Time = "14:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 9,
        ProfessionalId = 76,
        Date = DateTime.Parse("2023-12-14"),
        Time = "16:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 1,
        ProfessionalId = 83,
        Date = DateTime.Parse("2024-10-01"),
        Time = "12:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 96,
        ProfessionalId = 53,
        Date = DateTime.Parse("2024-04-15"),
        Time = "10:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 43,
        ProfessionalId = 50,
        Date = DateTime.Parse("2024-09-25"),
        Time = "13:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 7,
        ProfessionalId = 13,
        Date = DateTime.Parse("2023-12-19"),
        Time = "11:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 18,
        ProfessionalId = 94,
        Date = DateTime.Parse("2023-07-17"),
        Time = "15:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 74,
        ProfessionalId = 22,
        Date = DateTime.Parse("2023-03-30"),
        Time = "9:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 10,
        ProfessionalId = 4,
        Date = DateTime.Parse("2024-09-18"),
        Time = "9:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 78,
        ProfessionalId = 10,
        Date = DateTime.Parse("2023-09-15"),
        Time = "12:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 9,
        ProfessionalId = 72,
        Date = DateTime.Parse("2024-06-11"),
        Time = "16:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 80,
        ProfessionalId = 58,
        Date = DateTime.Parse("2023-05-06"),
        Time = "15:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 49,
        ProfessionalId = 35,
        Date = DateTime.Parse("2023-11-15"),
        Time = "13:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 53,
        ProfessionalId = 29,
        Date = DateTime.Parse("2023-08-04"),
        Time = "9:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 61,
        ProfessionalId = 34,
        Date = DateTime.Parse("2023-02-09"),
        Time = "12:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 68,
        ProfessionalId = 7,
        Date = DateTime.Parse("2024-08-21"),
        Time = "17:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 62,
        ProfessionalId = 11,
        Date = DateTime.Parse("2023-02-10"),
        Time = "15:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 87,
        ProfessionalId = 4,
        Date = DateTime.Parse("2024-04-28"),
        Time = "16:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 91,
        ProfessionalId = 97,
        Date = DateTime.Parse("2023-07-05"),
        Time = "15:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 33,
        ProfessionalId = 64,
        Date = DateTime.Parse("2024-07-10"),
        Time = "13:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 17,
        ProfessionalId = 9,
        Date = DateTime.Parse("2024-03-31"),
        Time = "17:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 76,
        ProfessionalId = 17,
        Date = DateTime.Parse("2023-09-27"),
        Time = "15:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 20,
        ProfessionalId = 16,
        Date = DateTime.Parse("2024-02-10"),
        Time = "11:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 79,
        ProfessionalId = 31,
        Date = DateTime.Parse("2023-09-23"),
        Time = "8:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 57,
        ProfessionalId = 20,
        Date = DateTime.Parse("2023-07-27"),
        Time = "10:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 54,
        ProfessionalId = 38,
        Date = DateTime.Parse("2023-08-18"),
        Time = "12:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 22,
        ProfessionalId = 80,
        Date = DateTime.Parse("2023-03-13"),
        Time = "9:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 99,
        ProfessionalId = 76,
        Date = DateTime.Parse("2023-01-26"),
        Time = "11:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 49,
        ProfessionalId = 30,
        Date = DateTime.Parse("2023-02-25"),
        Time = "16:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 47,
        ProfessionalId = 65,
        Date = DateTime.Parse("2023-07-13"),
        Time = "14:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 75,
        ProfessionalId = 73,
        Date = DateTime.Parse("2024-03-14"),
        Time = "9:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 99,
        ProfessionalId = 99,
        Date = DateTime.Parse("2023-09-29"),
        Time = "10:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 19,
        ProfessionalId = 14,
        Date = DateTime.Parse("2023-01-19"),
        Time = "16:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 80,
        ProfessionalId = 82,
        Date = DateTime.Parse("2024-07-13"),
        Time = "16:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 17,
        ProfessionalId = 97,
        Date = DateTime.Parse("2023-03-15"),
        Time = "11:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 29,
        ProfessionalId = 23,
        Date = DateTime.Parse("2023-09-13"),
        Time = "12:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 9,
        ProfessionalId = 77,
        Date = DateTime.Parse("2023-09-20"),
        Time = "11:30",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 17,
        ProfessionalId = 25,
        Date = DateTime.Parse("2023-02-20"),
        Time = "15:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 85,
        ProfessionalId = 25,
        Date = DateTime.Parse("2024-07-11"),
        Time = "12:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 47,
        ProfessionalId = 64,
        Date = DateTime.Parse("2023-02-12"),
        Time = "14:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 31,
        ProfessionalId = 57,
        Date = DateTime.Parse("2024-08-28"),
        Time = "10:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 70,
        ProfessionalId = 46,
        Date = DateTime.Parse("2023-11-11"),
        Time = "8:00",
        Status = "scheduled",
    },
    new Appointment
    {
        PatientId = 68,
        ProfessionalId = 30,
        Date = DateTime.Parse("2024-11-26"),
        Time = "8:30",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 87,
        ProfessionalId = 8,
        Date = DateTime.Parse("2024-06-10"),
        Time = "11:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 98,
        ProfessionalId = 81,
        Date = DateTime.Parse("2024-08-23"),
        Time = "17:30",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 75,
        ProfessionalId = 77,
        Date = DateTime.Parse("2023-08-25"),
        Time = "16:00",
        Status = "completed",
    },
    new Appointment
    {
        PatientId = 90,
        ProfessionalId = 41,
        Date = DateTime.Parse("2023-12-03"),
        Time = "9:00",
        Status = "cancelled",
    },
    new Appointment
    {
        PatientId = 70,
        ProfessionalId = 85,
        Date = DateTime.Parse("2023-07-07"),
        Time = "13:00",
        Status = "scheduled",
    },
            };
            context.Appointments.AddRange(appointments);
            context.SaveChanges();

            var medicalrecords = new MedicalRecord[]
            {
    new MedicalRecord
    {
        PatientId = 41,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-06-17"),
    },
    new MedicalRecord
    {
        PatientId = 7,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-07-30"),
    },
    new MedicalRecord
    {
        PatientId = 25,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-01-17"),
    },
    new MedicalRecord
    {
        PatientId = 52,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-10-14"),
    },
    new MedicalRecord
    {
        PatientId = 8,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-04-09"),
    },
    new MedicalRecord
    {
        PatientId = 85,
        Diagnosis = "Flu",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-06-02"),
    },
    new MedicalRecord
    {
        PatientId = 28,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-10-15"),
    },
    new MedicalRecord
    {
        PatientId = 86,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-03-03"),
    },
    new MedicalRecord
    {
        PatientId = 71,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-11-28"),
    },
    new MedicalRecord
    {
        PatientId = 90,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-09-15"),
    },
    new MedicalRecord
    {
        PatientId = 14,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-10-28"),
    },
    new MedicalRecord
    {
        PatientId = 33,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-07-11"),
    },
    new MedicalRecord
    {
        PatientId = 51,
        Diagnosis = "Hypertension",
        Treatment = "Inhaler",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-10-08"),
    },
    new MedicalRecord
    {
        PatientId = 42,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-07-27"),
    },
    new MedicalRecord
    {
        PatientId = 59,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-11-12"),
    },
    new MedicalRecord
    {
        PatientId = 70,
        Diagnosis = "Allergy",
        Treatment = "Inhaler",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-04-20"),
    },
    new MedicalRecord
    {
        PatientId = 95,
        Diagnosis = "Diabetes",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-06-19"),
    },
    new MedicalRecord
    {
        PatientId = 30,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-08-12"),
    },
    new MedicalRecord
    {
        PatientId = 29,
        Diagnosis = "Flu",
        Treatment = "Inhaler",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-03-09"),
    },
    new MedicalRecord
    {
        PatientId = 71,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-05-31"),
    },
    new MedicalRecord
    {
        PatientId = 16,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-04-17"),
    },
    new MedicalRecord
    {
        PatientId = 63,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-08-23"),
    },
    new MedicalRecord
    {
        PatientId = 53,
        Diagnosis = "Hypertension",
        Treatment = "Inhaler",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-01-19"),
    },
    new MedicalRecord
    {
        PatientId = 91,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-07-26"),
    },
    new MedicalRecord
    {
        PatientId = 6,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-09-26"),
    },
    new MedicalRecord
    {
        PatientId = 86,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-02-09"),
    },
    new MedicalRecord
    {
        PatientId = 23,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-06-09"),
    },
    new MedicalRecord
    {
        PatientId = 8,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-06-29"),
    },
    new MedicalRecord
    {
        PatientId = 55,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-02-24"),
    },
    new MedicalRecord
    {
        PatientId = 27,
        Diagnosis = "Diabetes",
        Treatment = "Inhaler",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-10-25"),
    },
    new MedicalRecord
    {
        PatientId = 56,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-07-09"),
    },
    new MedicalRecord
    {
        PatientId = 15,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-12-22"),
    },
    new MedicalRecord
    {
        PatientId = 27,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-01-24"),
    },
    new MedicalRecord
    {
        PatientId = 54,
        Diagnosis = "Diabetes",
        Treatment = "Inhaler",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-05-11"),
    },
    new MedicalRecord
    {
        PatientId = 7,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-12-14"),
    },
    new MedicalRecord
    {
        PatientId = 83,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-06-01"),
    },
    new MedicalRecord
    {
        PatientId = 92,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-09-05"),
    },
    new MedicalRecord
    {
        PatientId = 18,
        Diagnosis = "Allergy",
        Treatment = "Inhaler",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-06-15"),
    },
    new MedicalRecord
    {
        PatientId = 72,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-09-14"),
    },
    new MedicalRecord
    {
        PatientId = 29,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-01-09"),
    },
    new MedicalRecord
    {
        PatientId = 68,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-05-11"),
    },
    new MedicalRecord
    {
        PatientId = 63,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-04-21"),
    },
    new MedicalRecord
    {
        PatientId = 90,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-08-08"),
    },
    new MedicalRecord
    {
        PatientId = 87,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-01-23"),
    },
    new MedicalRecord
    {
        PatientId = 91,
        Diagnosis = "Flu",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-04-14"),
    },
    new MedicalRecord
    {
        PatientId = 62,
        Diagnosis = "Flu",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-07-20"),
    },
    new MedicalRecord
    {
        PatientId = 64,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-06-07"),
    },
    new MedicalRecord
    {
        PatientId = 13,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-11-25"),
    },
    new MedicalRecord
    {
        PatientId = 96,
        Diagnosis = "Diabetes",
        Treatment = "Inhaler",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-11-06"),
    },
    new MedicalRecord
    {
        PatientId = 79,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-02-24"),
    },
    new MedicalRecord
    {
        PatientId = 34,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-12-11"),
    },
    new MedicalRecord
    {
        PatientId = 27,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-01-11"),
    },
    new MedicalRecord
    {
        PatientId = 57,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-03-16"),
    },
    new MedicalRecord
    {
        PatientId = 54,
        Diagnosis = "Hypertension",
        Treatment = "Inhaler",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-06-05"),
    },
    new MedicalRecord
    {
        PatientId = 75,
        Diagnosis = "Diabetes",
        Treatment = "Rest",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-12-23"),
    },
    new MedicalRecord
    {
        PatientId = 2,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-03-10"),
    },
    new MedicalRecord
    {
        PatientId = 29,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-05-21"),
    },
    new MedicalRecord
    {
        PatientId = 27,
        Diagnosis = "Flu",
        Treatment = "Inhaler",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-04-11"),
    },
    new MedicalRecord
    {
        PatientId = 86,
        Diagnosis = "Allergy",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-11-16"),
    },
    new MedicalRecord
    {
        PatientId = 74,
        Diagnosis = "Diabetes",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-03-02"),
    },
    new MedicalRecord
    {
        PatientId = 87,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-02-21"),
    },
    new MedicalRecord
    {
        PatientId = 4,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-09-09"),
    },
    new MedicalRecord
    {
        PatientId = 66,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-10-18"),
    },
    new MedicalRecord
    {
        PatientId = 41,
        Diagnosis = "Flu",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-03-18"),
    },
    new MedicalRecord
    {
        PatientId = 9,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-04-28"),
    },
    new MedicalRecord
    {
        PatientId = 84,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-03-03"),
    },
    new MedicalRecord
    {
        PatientId = 15,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-05-29"),
    },
    new MedicalRecord
    {
        PatientId = 65,
        Diagnosis = "Flu",
        Treatment = "Inhaler",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-10-22"),
    },
    new MedicalRecord
    {
        PatientId = 93,
        Diagnosis = "Allergy",
        Treatment = "Inhaler",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-09-14"),
    },
    new MedicalRecord
    {
        PatientId = 56,
        Diagnosis = "Diabetes",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-03-27"),
    },
    new MedicalRecord
    {
        PatientId = 28,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-01-25"),
    },
    new MedicalRecord
    {
        PatientId = 88,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-11-29"),
    },
    new MedicalRecord
    {
        PatientId = 60,
        Diagnosis = "Flu",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-02-09"),
    },
    new MedicalRecord
    {
        PatientId = 39,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-07-24"),
    },
    new MedicalRecord
    {
        PatientId = 6,
        Diagnosis = "Allergy",
        Treatment = "Inhaler",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-10-11"),
    },
    new MedicalRecord
    {
        PatientId = 79,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-05-21"),
    },
    new MedicalRecord
    {
        PatientId = 60,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-10-05"),
    },
    new MedicalRecord
    {
        PatientId = 42,
        Diagnosis = "Diabetes",
        Treatment = "Rest",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2023-04-23"),
    },
    new MedicalRecord
    {
        PatientId = 75,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-10-27"),
    },
    new MedicalRecord
    {
        PatientId = 41,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-03-28"),
    },
    new MedicalRecord
    {
        PatientId = 44,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-07-08"),
    },
    new MedicalRecord
    {
        PatientId = 44,
        Diagnosis = "Hypertension",
        Treatment = "Rest",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-10-06"),
    },
    new MedicalRecord
    {
        PatientId = 6,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-08-06"),
    },
    new MedicalRecord
    {
        PatientId = 81,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-04-08"),
    },
    new MedicalRecord
    {
        PatientId = 22,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-12-06"),
    },
    new MedicalRecord
    {
        PatientId = 93,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2023-06-27"),
    },
    new MedicalRecord
    {
        PatientId = 14,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2022-03-29"),
    },
    new MedicalRecord
    {
        PatientId = 84,
        Diagnosis = "Allergy",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-10-08"),
    },
    new MedicalRecord
    {
        PatientId = 22,
        Diagnosis = "Flu",
        Treatment = "Inhaler",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-03-25"),
    },
    new MedicalRecord
    {
        PatientId = 94,
        Diagnosis = "Hypertension",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-11-05"),
    },
    new MedicalRecord
    {
        PatientId = 68,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-04-27"),
    },
    new MedicalRecord
    {
        PatientId = 97,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-04-12"),
    },
    new MedicalRecord
    {
        PatientId = 12,
        Diagnosis = "Diabetes",
        Treatment = "Insulin",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-08-29"),
    },
    new MedicalRecord
    {
        PatientId = 18,
        Diagnosis = "Hypertension",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2021-01-24"),
    },
    new MedicalRecord
    {
        PatientId = 18,
        Diagnosis = "Hypertension",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2021-06-06"),
    },
    new MedicalRecord
    {
        PatientId = 7,
        Diagnosis = "Hypertension",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-07-20"),
    },
    new MedicalRecord
    {
        PatientId = 7,
        Diagnosis = "Hypertension",
        Treatment = "Inhaler",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2023-02-11"),
    },
    new MedicalRecord
    {
        PatientId = 13,
        Diagnosis = "Flu",
        Treatment = "Insulin",
        Prescription = "Metformin",
        DateCreated = DateTime.Parse("2022-04-06"),
    },
    new MedicalRecord
    {
        PatientId = 31,
        Diagnosis = "Hypertension",
        Treatment = "Rest",
        Prescription = "Paracetamol",
        DateCreated = DateTime.Parse("2022-09-21"),
    },
    new MedicalRecord
    {
        PatientId = 67,
        Diagnosis = "Allergy",
        Treatment = "Medication",
        Prescription = "Ibuprofen",
        DateCreated = DateTime.Parse("2021-12-11"),
    },
            };
            context.MedicalRecords.AddRange(medicalrecords);
            context.SaveChanges();

            var medications = new Medication[]
            {
    new Medication
    {
        PatientId = 69,
        Name = "Aspirin",
        Dosage = "364mg",
        StartDate = DateTime.Parse("2022-11-30"),
        EndDate = DateTime.Parse("2023-01-30"),
    },
    new Medication
    {
        PatientId = 70,
        Name = "Aspirin",
        Dosage = "382mg",
        StartDate = DateTime.Parse("2022-08-04"),
        EndDate = DateTime.Parse("2022-10-05"),
    },
    new Medication
    {
        PatientId = 95,
        Name = "Aspirin",
        Dosage = "367mg",
        StartDate = DateTime.Parse("2023-04-21"),
        EndDate = DateTime.Parse("2023-06-30"),
    },
    new Medication
    {
        PatientId = 78,
        Name = "Aspirin",
        Dosage = "139mg",
        StartDate = DateTime.Parse("2021-10-16"),
        EndDate = DateTime.Parse("2022-01-23"),
    },
    new Medication
    {
        PatientId = 80,
        Name = "Aspirin",
        Dosage = "46mg",
        StartDate = DateTime.Parse("2023-06-21"),
        EndDate = DateTime.Parse("2023-12-06"),
    },
    new Medication
    {
        PatientId = 58,
        Name = "Aspirin",
        Dosage = "45mg",
        StartDate = DateTime.Parse("2022-10-22"),
        EndDate = DateTime.Parse("2023-01-19"),
    },
    new Medication
    {
        PatientId = 37,
        Name = "Aspirin",
        Dosage = "396mg",
        StartDate = DateTime.Parse("2023-07-26"),
        EndDate = DateTime.Parse("2023-12-16"),
    },
    new Medication
    {
        PatientId = 4,
        Name = "Metformin",
        Dosage = "449mg",
        StartDate = DateTime.Parse("2022-05-07"),
        EndDate = DateTime.Parse("2022-10-03"),
    },
    new Medication
    {
        PatientId = 34,
        Name = "Aspirin",
        Dosage = "64mg",
        StartDate = DateTime.Parse("2023-07-11"),
        EndDate = DateTime.Parse("2024-01-04"),
    },
    new Medication
    {
        PatientId = 30,
        Name = "Aspirin",
        Dosage = "329mg",
        StartDate = DateTime.Parse("2021-03-24"),
        EndDate = DateTime.Parse("2021-08-16"),
    },
    new Medication
    {
        PatientId = 90,
        Name = "Metformin",
        Dosage = "240mg",
        StartDate = DateTime.Parse("2023-03-12"),
        EndDate = DateTime.Parse("2023-05-30"),
    },
    new Medication
    {
        PatientId = 60,
        Name = "Aspirin",
        Dosage = "472mg",
        StartDate = DateTime.Parse("2021-06-15"),
        EndDate = DateTime.Parse("2021-09-14"),
    },
    new Medication
    {
        PatientId = 51,
        Name = "Metformin",
        Dosage = "54mg",
        StartDate = DateTime.Parse("2022-06-26"),
        EndDate = DateTime.Parse("2022-10-10"),
    },
    new Medication
    {
        PatientId = 56,
        Name = "Metformin",
        Dosage = "265mg",
        StartDate = DateTime.Parse("2023-08-20"),
        EndDate = DateTime.Parse("2024-01-15"),
    },
    new Medication
    {
        PatientId = 90,
        Name = "Lipitor",
        Dosage = "173mg",
        StartDate = DateTime.Parse("2023-09-23"),
        EndDate = DateTime.Parse("2023-11-24"),
    },
    new Medication
    {
        PatientId = 17,
        Name = "Lipitor",
        Dosage = "51mg",
        StartDate = DateTime.Parse("2021-01-26"),
        EndDate = DateTime.Parse("2021-07-10"),
    },
    new Medication
    {
        PatientId = 36,
        Name = "Metformin",
        Dosage = "230mg",
        StartDate = DateTime.Parse("2023-09-30"),
        EndDate = DateTime.Parse("2024-01-05"),
    },
    new Medication
    {
        PatientId = 59,
        Name = "Aspirin",
        Dosage = "387mg",
        StartDate = DateTime.Parse("2022-12-17"),
        EndDate = DateTime.Parse("2023-02-07"),
    },
    new Medication
    {
        PatientId = 55,
        Name = "Aspirin",
        Dosage = "214mg",
        StartDate = DateTime.Parse("2021-03-19"),
        EndDate = DateTime.Parse("2021-07-26"),
    },
    new Medication
    {
        PatientId = 46,
        Name = "Metformin",
        Dosage = "25mg",
        StartDate = DateTime.Parse("2021-04-27"),
        EndDate = DateTime.Parse("2021-08-11"),
    },
    new Medication
    {
        PatientId = 3,
        Name = "Metformin",
        Dosage = "95mg",
        StartDate = DateTime.Parse("2022-01-17"),
        EndDate = DateTime.Parse("2022-05-15"),
    },
    new Medication
    {
        PatientId = 31,
        Name = "Metformin",
        Dosage = "304mg",
        StartDate = DateTime.Parse("2021-07-24"),
        EndDate = DateTime.Parse("2021-12-12"),
    },
    new Medication
    {
        PatientId = 86,
        Name = "Aspirin",
        Dosage = "454mg",
        StartDate = DateTime.Parse("2022-02-20"),
        EndDate = DateTime.Parse("2022-06-13"),
    },
    new Medication
    {
        PatientId = 13,
        Name = "Lipitor",
        Dosage = "171mg",
        StartDate = DateTime.Parse("2021-12-05"),
        EndDate = DateTime.Parse("2022-05-21"),
    },
    new Medication
    {
        PatientId = 50,
        Name = "Metformin",
        Dosage = "257mg",
        StartDate = DateTime.Parse("2022-04-25"),
        EndDate = DateTime.Parse("2022-08-11"),
    },
    new Medication
    {
        PatientId = 60,
        Name = "Aspirin",
        Dosage = "263mg",
        StartDate = DateTime.Parse("2023-11-16"),
        EndDate = DateTime.Parse("2024-02-17"),
    },
    new Medication
    {
        PatientId = 90,
        Name = "Lipitor",
        Dosage = "267mg",
        StartDate = DateTime.Parse("2022-07-07"),
        EndDate = DateTime.Parse("2022-09-21"),
    },
    new Medication
    {
        PatientId = 5,
        Name = "Aspirin",
        Dosage = "55mg",
        StartDate = DateTime.Parse("2021-06-30"),
        EndDate = DateTime.Parse("2021-11-11"),
    },
    new Medication
    {
        PatientId = 61,
        Name = "Metformin",
        Dosage = "392mg",
        StartDate = DateTime.Parse("2023-07-06"),
        EndDate = DateTime.Parse("2023-11-02"),
    },
    new Medication
    {
        PatientId = 2,
        Name = "Lipitor",
        Dosage = "28mg",
        StartDate = DateTime.Parse("2021-03-19"),
        EndDate = DateTime.Parse("2021-09-01"),
    },
    new Medication
    {
        PatientId = 28,
        Name = "Aspirin",
        Dosage = "241mg",
        StartDate = DateTime.Parse("2021-06-28"),
        EndDate = DateTime.Parse("2021-09-05"),
    },
    new Medication
    {
        PatientId = 86,
        Name = "Metformin",
        Dosage = "191mg",
        StartDate = DateTime.Parse("2023-09-19"),
        EndDate = DateTime.Parse("2023-12-01"),
    },
    new Medication
    {
        PatientId = 21,
        Name = "Metformin",
        Dosage = "277mg",
        StartDate = DateTime.Parse("2023-07-14"),
        EndDate = DateTime.Parse("2023-10-10"),
    },
    new Medication
    {
        PatientId = 53,
        Name = "Aspirin",
        Dosage = "466mg",
        StartDate = DateTime.Parse("2021-09-23"),
        EndDate = DateTime.Parse("2021-10-31"),
    },
    new Medication
    {
        PatientId = 64,
        Name = "Metformin",
        Dosage = "62mg",
        StartDate = DateTime.Parse("2022-10-07"),
        EndDate = DateTime.Parse("2022-11-18"),
    },
    new Medication
    {
        PatientId = 36,
        Name = "Lipitor",
        Dosage = "391mg",
        StartDate = DateTime.Parse("2022-11-06"),
        EndDate = DateTime.Parse("2023-04-02"),
    },
    new Medication
    {
        PatientId = 70,
        Name = "Lipitor",
        Dosage = "336mg",
        StartDate = DateTime.Parse("2021-06-04"),
        EndDate = DateTime.Parse("2021-11-30"),
    },
    new Medication
    {
        PatientId = 66,
        Name = "Metformin",
        Dosage = "426mg",
        StartDate = DateTime.Parse("2022-08-17"),
        EndDate = DateTime.Parse("2022-10-07"),
    },
    new Medication
    {
        PatientId = 99,
        Name = "Metformin",
        Dosage = "472mg",
        StartDate = DateTime.Parse("2022-07-29"),
        EndDate = DateTime.Parse("2022-12-15"),
    },
    new Medication
    {
        PatientId = 80,
        Name = "Metformin",
        Dosage = "272mg",
        StartDate = DateTime.Parse("2023-05-25"),
        EndDate = DateTime.Parse("2023-09-28"),
    },
    new Medication
    {
        PatientId = 39,
        Name = "Lipitor",
        Dosage = "133mg",
        StartDate = DateTime.Parse("2021-02-05"),
        EndDate = DateTime.Parse("2021-06-30"),
    },
    new Medication
    {
        PatientId = 60,
        Name = "Aspirin",
        Dosage = "338mg",
        StartDate = DateTime.Parse("2021-10-12"),
        EndDate = DateTime.Parse("2021-11-11"),
    },
    new Medication
    {
        PatientId = 83,
        Name = "Lipitor",
        Dosage = "35mg",
        StartDate = DateTime.Parse("2023-06-02"),
        EndDate = DateTime.Parse("2023-09-04"),
    },
    new Medication
    {
        PatientId = 97,
        Name = "Aspirin",
        Dosage = "444mg",
        StartDate = DateTime.Parse("2021-02-11"),
        EndDate = DateTime.Parse("2021-08-01"),
    },
    new Medication
    {
        PatientId = 2,
        Name = "Aspirin",
        Dosage = "181mg",
        StartDate = DateTime.Parse("2023-06-07"),
        EndDate = DateTime.Parse("2023-08-21"),
    },
    new Medication
    {
        PatientId = 54,
        Name = "Aspirin",
        Dosage = "368mg",
        StartDate = DateTime.Parse("2023-03-24"),
        EndDate = DateTime.Parse("2023-08-15"),
    },
    new Medication
    {
        PatientId = 45,
        Name = "Metformin",
        Dosage = "53mg",
        StartDate = DateTime.Parse("2023-09-27"),
        EndDate = DateTime.Parse("2024-03-05"),
    },
    new Medication
    {
        PatientId = 93,
        Name = "Aspirin",
        Dosage = "384mg",
        StartDate = DateTime.Parse("2023-11-01"),
        EndDate = DateTime.Parse("2024-02-05"),
    },
    new Medication
    {
        PatientId = 69,
        Name = "Metformin",
        Dosage = "220mg",
        StartDate = DateTime.Parse("2023-09-07"),
        EndDate = DateTime.Parse("2024-02-26"),
    },
    new Medication
    {
        PatientId = 88,
        Name = "Metformin",
        Dosage = "286mg",
        StartDate = DateTime.Parse("2023-05-08"),
        EndDate = DateTime.Parse("2023-10-28"),
    },
    new Medication
    {
        PatientId = 84,
        Name = "Metformin",
        Dosage = "227mg",
        StartDate = DateTime.Parse("2023-10-11"),
        EndDate = DateTime.Parse("2023-12-26"),
    },
    new Medication
    {
        PatientId = 81,
        Name = "Metformin",
        Dosage = "267mg",
        StartDate = DateTime.Parse("2023-01-27"),
        EndDate = DateTime.Parse("2023-05-13"),
    },
    new Medication
    {
        PatientId = 89,
        Name = "Aspirin",
        Dosage = "24mg",
        StartDate = DateTime.Parse("2021-10-14"),
        EndDate = DateTime.Parse("2022-01-27"),
    },
    new Medication
    {
        PatientId = 91,
        Name = "Lipitor",
        Dosage = "492mg",
        StartDate = DateTime.Parse("2023-02-24"),
        EndDate = DateTime.Parse("2023-08-04"),
    },
    new Medication
    {
        PatientId = 80,
        Name = "Aspirin",
        Dosage = "257mg",
        StartDate = DateTime.Parse("2022-11-12"),
        EndDate = DateTime.Parse("2023-05-07"),
    },
    new Medication
    {
        PatientId = 45,
        Name = "Metformin",
        Dosage = "23mg",
        StartDate = DateTime.Parse("2022-02-27"),
        EndDate = DateTime.Parse("2022-05-16"),
    },
    new Medication
    {
        PatientId = 2,
        Name = "Metformin",
        Dosage = "437mg",
        StartDate = DateTime.Parse("2023-10-03"),
        EndDate = DateTime.Parse("2024-03-04"),
    },
    new Medication
    {
        PatientId = 80,
        Name = "Lipitor",
        Dosage = "311mg",
        StartDate = DateTime.Parse("2023-05-24"),
        EndDate = DateTime.Parse("2023-11-01"),
    },
    new Medication
    {
        PatientId = 12,
        Name = "Lipitor",
        Dosage = "404mg",
        StartDate = DateTime.Parse("2023-02-15"),
        EndDate = DateTime.Parse("2023-07-02"),
    },
    new Medication
    {
        PatientId = 34,
        Name = "Lipitor",
        Dosage = "275mg",
        StartDate = DateTime.Parse("2021-07-22"),
        EndDate = DateTime.Parse("2021-10-14"),
    },
    new Medication
    {
        PatientId = 78,
        Name = "Aspirin",
        Dosage = "80mg",
        StartDate = DateTime.Parse("2023-12-16"),
        EndDate = DateTime.Parse("2024-03-25"),
    },
    new Medication
    {
        PatientId = 22,
        Name = "Aspirin",
        Dosage = "488mg",
        StartDate = DateTime.Parse("2021-03-22"),
        EndDate = DateTime.Parse("2021-04-23"),
    },
    new Medication
    {
        PatientId = 48,
        Name = "Aspirin",
        Dosage = "302mg",
        StartDate = DateTime.Parse("2022-05-25"),
        EndDate = DateTime.Parse("2022-09-14"),
    },
    new Medication
    {
        PatientId = 53,
        Name = "Aspirin",
        Dosage = "357mg",
        StartDate = DateTime.Parse("2022-05-02"),
        EndDate = DateTime.Parse("2022-06-18"),
    },
    new Medication
    {
        PatientId = 56,
        Name = "Lipitor",
        Dosage = "111mg",
        StartDate = DateTime.Parse("2022-02-16"),
        EndDate = DateTime.Parse("2022-04-18"),
    },
    new Medication
    {
        PatientId = 53,
        Name = "Lipitor",
        Dosage = "108mg",
        StartDate = DateTime.Parse("2023-09-22"),
        EndDate = DateTime.Parse("2023-12-03"),
    },
    new Medication
    {
        PatientId = 63,
        Name = "Aspirin",
        Dosage = "66mg",
        StartDate = DateTime.Parse("2023-09-19"),
        EndDate = DateTime.Parse("2023-11-29"),
    },
    new Medication
    {
        PatientId = 73,
        Name = "Metformin",
        Dosage = "190mg",
        StartDate = DateTime.Parse("2021-11-06"),
        EndDate = DateTime.Parse("2022-03-04"),
    },
    new Medication
    {
        PatientId = 99,
        Name = "Lipitor",
        Dosage = "209mg",
        StartDate = DateTime.Parse("2023-08-14"),
        EndDate = DateTime.Parse("2023-09-16"),
    },
    new Medication
    {
        PatientId = 44,
        Name = "Aspirin",
        Dosage = "92mg",
        StartDate = DateTime.Parse("2021-12-19"),
        EndDate = DateTime.Parse("2022-01-24"),
    },
    new Medication
    {
        PatientId = 39,
        Name = "Lipitor",
        Dosage = "171mg",
        StartDate = DateTime.Parse("2022-04-30"),
        EndDate = DateTime.Parse("2022-06-12"),
    },
    new Medication
    {
        PatientId = 54,
        Name = "Aspirin",
        Dosage = "11mg",
        StartDate = DateTime.Parse("2022-12-17"),
        EndDate = DateTime.Parse("2023-02-04"),
    },
    new Medication
    {
        PatientId = 75,
        Name = "Lipitor",
        Dosage = "194mg",
        StartDate = DateTime.Parse("2022-01-19"),
        EndDate = DateTime.Parse("2022-06-10"),
    },
    new Medication
    {
        PatientId = 90,
        Name = "Aspirin",
        Dosage = "164mg",
        StartDate = DateTime.Parse("2022-06-04"),
        EndDate = DateTime.Parse("2022-10-25"),
    },
    new Medication
    {
        PatientId = 80,
        Name = "Aspirin",
        Dosage = "15mg",
        StartDate = DateTime.Parse("2021-02-18"),
        EndDate = DateTime.Parse("2021-06-12"),
    },
    new Medication
    {
        PatientId = 59,
        Name = "Aspirin",
        Dosage = "442mg",
        StartDate = DateTime.Parse("2021-07-14"),
        EndDate = DateTime.Parse("2022-01-08"),
    },
    new Medication
    {
        PatientId = 59,
        Name = "Aspirin",
        Dosage = "369mg",
        StartDate = DateTime.Parse("2023-06-03"),
        EndDate = DateTime.Parse("2023-07-05"),
    },
    new Medication
    {
        PatientId = 90,
        Name = "Lipitor",
        Dosage = "233mg",
        StartDate = DateTime.Parse("2023-09-29"),
        EndDate = DateTime.Parse("2023-10-29"),
    },
    new Medication
    {
        PatientId = 61,
        Name = "Metformin",
        Dosage = "467mg",
        StartDate = DateTime.Parse("2021-12-10"),
        EndDate = DateTime.Parse("2022-02-02"),
    },
    new Medication
    {
        PatientId = 57,
        Name = "Metformin",
        Dosage = "136mg",
        StartDate = DateTime.Parse("2023-04-25"),
        EndDate = DateTime.Parse("2023-09-29"),
    },
    new Medication
    {
        PatientId = 48,
        Name = "Lipitor",
        Dosage = "138mg",
        StartDate = DateTime.Parse("2023-12-22"),
        EndDate = DateTime.Parse("2024-03-28"),
    },
    new Medication
    {
        PatientId = 97,
        Name = "Metformin",
        Dosage = "468mg",
        StartDate = DateTime.Parse("2023-05-05"),
        EndDate = DateTime.Parse("2023-06-10"),
    },
    new Medication
    {
        PatientId = 81,
        Name = "Lipitor",
        Dosage = "52mg",
        StartDate = DateTime.Parse("2022-10-27"),
        EndDate = DateTime.Parse("2023-03-06"),
    },
    new Medication
    {
        PatientId = 59,
        Name = "Lipitor",
        Dosage = "211mg",
        StartDate = DateTime.Parse("2023-12-15"),
        EndDate = DateTime.Parse("2024-01-20"),
    },
    new Medication
    {
        PatientId = 23,
        Name = "Lipitor",
        Dosage = "11mg",
        StartDate = DateTime.Parse("2021-11-09"),
        EndDate = DateTime.Parse("2022-02-03"),
    },
    new Medication
    {
        PatientId = 91,
        Name = "Metformin",
        Dosage = "81mg",
        StartDate = DateTime.Parse("2021-10-19"),
        EndDate = DateTime.Parse("2022-02-02"),
    },
    new Medication
    {
        PatientId = 73,
        Name = "Lipitor",
        Dosage = "500mg",
        StartDate = DateTime.Parse("2022-05-14"),
        EndDate = DateTime.Parse("2022-09-23"),
    },
    new Medication
    {
        PatientId = 9,
        Name = "Aspirin",
        Dosage = "368mg",
        StartDate = DateTime.Parse("2021-06-06"),
        EndDate = DateTime.Parse("2021-07-18"),
    },
    new Medication
    {
        PatientId = 96,
        Name = "Metformin",
        Dosage = "37mg",
        StartDate = DateTime.Parse("2021-10-25"),
        EndDate = DateTime.Parse("2022-03-23"),
    },
    new Medication
    {
        PatientId = 6,
        Name = "Lipitor",
        Dosage = "72mg",
        StartDate = DateTime.Parse("2023-11-26"),
        EndDate = DateTime.Parse("2024-04-30"),
    },
    new Medication
    {
        PatientId = 68,
        Name = "Aspirin",
        Dosage = "204mg",
        StartDate = DateTime.Parse("2021-11-01"),
        EndDate = DateTime.Parse("2022-03-02"),
    },
    new Medication
    {
        PatientId = 52,
        Name = "Metformin",
        Dosage = "471mg",
        StartDate = DateTime.Parse("2023-01-07"),
        EndDate = DateTime.Parse("2023-02-26"),
    },
    new Medication
    {
        PatientId = 35,
        Name = "Metformin",
        Dosage = "97mg",
        StartDate = DateTime.Parse("2022-05-29"),
        EndDate = DateTime.Parse("2022-09-01"),
    },
    new Medication
    {
        PatientId = 45,
        Name = "Metformin",
        Dosage = "191mg",
        StartDate = DateTime.Parse("2022-03-23"),
        EndDate = DateTime.Parse("2022-09-07"),
    },
    new Medication
    {
        PatientId = 63,
        Name = "Aspirin",
        Dosage = "353mg",
        StartDate = DateTime.Parse("2023-12-13"),
        EndDate = DateTime.Parse("2024-04-07"),
    },
    new Medication
    {
        PatientId = 45,
        Name = "Aspirin",
        Dosage = "31mg",
        StartDate = DateTime.Parse("2023-07-23"),
        EndDate = DateTime.Parse("2023-11-13"),
    },
    new Medication
    {
        PatientId = 47,
        Name = "Lipitor",
        Dosage = "188mg",
        StartDate = DateTime.Parse("2022-06-26"),
        EndDate = DateTime.Parse("2022-09-04"),
    },
    new Medication
    {
        PatientId = 4,
        Name = "Aspirin",
        Dosage = "264mg",
        StartDate = DateTime.Parse("2023-09-04"),
        EndDate = DateTime.Parse("2023-11-27"),
    },
    new Medication
    {
        PatientId = 59,
        Name = "Metformin",
        Dosage = "215mg",
        StartDate = DateTime.Parse("2023-10-06"),
        EndDate = DateTime.Parse("2024-03-20"),
    },
    new Medication
    {
        PatientId = 52,
        Name = "Lipitor",
        Dosage = "214mg",
        StartDate = DateTime.Parse("2022-04-10"),
        EndDate = DateTime.Parse("2022-07-10"),
    },
            };
            context.Medications.AddRange(medications);
            context.SaveChanges();

            var diagnostics = new Diagnostic[]
            {
    new Diagnostic
    {
        PatientId = 75,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-07-25"),
    },
    new Diagnostic
    {
        PatientId = 72,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-04-01"),
    },
    new Diagnostic
    {
        PatientId = 96,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-04-19"),
    },
    new Diagnostic
    {
        PatientId = 55,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-04-05"),
    },
    new Diagnostic
    {
        PatientId = 41,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-09-22"),
    },
    new Diagnostic
    {
        PatientId = 32,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-09-16"),
    },
    new Diagnostic
    {
        PatientId = 30,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2021-07-26"),
    },
    new Diagnostic
    {
        PatientId = 2,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-01-11"),
    },
    new Diagnostic
    {
        PatientId = 13,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-10-22"),
    },
    new Diagnostic
    {
        PatientId = 85,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-08-30"),
    },
    new Diagnostic
    {
        PatientId = 30,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-12-20"),
    },
    new Diagnostic
    {
        PatientId = 70,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-01-04"),
    },
    new Diagnostic
    {
        PatientId = 57,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-04-28"),
    },
    new Diagnostic
    {
        PatientId = 45,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-08-08"),
    },
    new Diagnostic
    {
        PatientId = 37,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-01-28"),
    },
    new Diagnostic
    {
        PatientId = 4,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-08-07"),
    },
    new Diagnostic
    {
        PatientId = 75,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-12-31"),
    },
    new Diagnostic
    {
        PatientId = 67,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-05-29"),
    },
    new Diagnostic
    {
        PatientId = 32,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-04-20"),
    },
    new Diagnostic
    {
        PatientId = 48,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-01-13"),
    },
    new Diagnostic
    {
        PatientId = 15,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-09-19"),
    },
    new Diagnostic
    {
        PatientId = 4,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-10-16"),
    },
    new Diagnostic
    {
        PatientId = 48,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-10-06"),
    },
    new Diagnostic
    {
        PatientId = 92,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2021-01-20"),
    },
    new Diagnostic
    {
        PatientId = 56,
        Name = "ECG",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-11-17"),
    },
    new Diagnostic
    {
        PatientId = 51,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-08-16"),
    },
    new Diagnostic
    {
        PatientId = 49,
        Name = "ECG",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-08-15"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-08-14"),
    },
    new Diagnostic
    {
        PatientId = 71,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-06-15"),
    },
    new Diagnostic
    {
        PatientId = 62,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-01-14"),
    },
    new Diagnostic
    {
        PatientId = 72,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-01-23"),
    },
    new Diagnostic
    {
        PatientId = 19,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-11-29"),
    },
    new Diagnostic
    {
        PatientId = 38,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-06-11"),
    },
    new Diagnostic
    {
        PatientId = 22,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-09-11"),
    },
    new Diagnostic
    {
        PatientId = 2,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-09-01"),
    },
    new Diagnostic
    {
        PatientId = 55,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-02-25"),
    },
    new Diagnostic
    {
        PatientId = 46,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-06-06"),
    },
    new Diagnostic
    {
        PatientId = 100,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-06-17"),
    },
    new Diagnostic
    {
        PatientId = 93,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-01-04"),
    },
    new Diagnostic
    {
        PatientId = 60,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-04-04"),
    },
    new Diagnostic
    {
        PatientId = 80,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-11-07"),
    },
    new Diagnostic
    {
        PatientId = 62,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-11-05"),
    },
    new Diagnostic
    {
        PatientId = 92,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-10-14"),
    },
    new Diagnostic
    {
        PatientId = 37,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-01-14"),
    },
    new Diagnostic
    {
        PatientId = 5,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-03-11"),
    },
    new Diagnostic
    {
        PatientId = 48,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-03-21"),
    },
    new Diagnostic
    {
        PatientId = 99,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-05-05"),
    },
    new Diagnostic
    {
        PatientId = 63,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-09-07"),
    },
    new Diagnostic
    {
        PatientId = 40,
        Name = "ECG",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-05-12"),
    },
    new Diagnostic
    {
        PatientId = 11,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-08-19"),
    },
    new Diagnostic
    {
        PatientId = 41,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-01-30"),
    },
    new Diagnostic
    {
        PatientId = 94,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-10-08"),
    },
    new Diagnostic
    {
        PatientId = 100,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-08-26"),
    },
    new Diagnostic
    {
        PatientId = 11,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-11-22"),
    },
    new Diagnostic
    {
        PatientId = 14,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-06-05"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-04-06"),
    },
    new Diagnostic
    {
        PatientId = 84,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-09-29"),
    },
    new Diagnostic
    {
        PatientId = 33,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-03-09"),
    },
    new Diagnostic
    {
        PatientId = 7,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-01-29"),
    },
    new Diagnostic
    {
        PatientId = 22,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-01-19"),
    },
    new Diagnostic
    {
        PatientId = 11,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-11-27"),
    },
    new Diagnostic
    {
        PatientId = 23,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-03-07"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-05-11"),
    },
    new Diagnostic
    {
        PatientId = 89,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-02-05"),
    },
    new Diagnostic
    {
        PatientId = 83,
        Name = "Blood Test",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-10-06"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-09-03"),
    },
    new Diagnostic
    {
        PatientId = 23,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-01-14"),
    },
    new Diagnostic
    {
        PatientId = 27,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-05-11"),
    },
    new Diagnostic
    {
        PatientId = 76,
        Name = "Blood Test",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2021-09-05"),
    },
    new Diagnostic
    {
        PatientId = 38,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-01-09"),
    },
    new Diagnostic
    {
        PatientId = 66,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-03-22"),
    },
    new Diagnostic
    {
        PatientId = 92,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-09-03"),
    },
    new Diagnostic
    {
        PatientId = 44,
        Name = "ECG",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-03-05"),
    },
    new Diagnostic
    {
        PatientId = 73,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2022-11-12"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-05-13"),
    },
    new Diagnostic
    {
        PatientId = 68,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-03-22"),
    },
    new Diagnostic
    {
        PatientId = 18,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-01-28"),
    },
    new Diagnostic
    {
        PatientId = 8,
        Name = "Blood Test",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-05-20"),
    },
    new Diagnostic
    {
        PatientId = 28,
        Name = "X-Ray",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-05-20"),
    },
    new Diagnostic
    {
        PatientId = 20,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-03-11"),
    },
    new Diagnostic
    {
        PatientId = 72,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-06-17"),
    },
    new Diagnostic
    {
        PatientId = 91,
        Name = "X-Ray",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-04-05"),
    },
    new Diagnostic
    {
        PatientId = 92,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-03-09"),
    },
    new Diagnostic
    {
        PatientId = 40,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-08-14"),
    },
    new Diagnostic
    {
        PatientId = 31,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-08-26"),
    },
    new Diagnostic
    {
        PatientId = 81,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2023-04-11"),
    },
    new Diagnostic
    {
        PatientId = 3,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-12-11"),
    },
    new Diagnostic
    {
        PatientId = 1,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-01-27"),
    },
    new Diagnostic
    {
        PatientId = 45,
        Name = "ECG",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2021-03-13"),
    },
    new Diagnostic
    {
        PatientId = 17,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2021-02-16"),
    },
    new Diagnostic
    {
        PatientId = 3,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-01-23"),
    },
    new Diagnostic
    {
        PatientId = 49,
        Name = "MRI",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-08-02"),
    },
    new Diagnostic
    {
        PatientId = 30,
        Name = "Blood Test",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2022-02-14"),
    },
    new Diagnostic
    {
        PatientId = 62,
        Name = "ECG",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-10-23"),
    },
    new Diagnostic
    {
        PatientId = 5,
        Name = "MRI",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-06-23"),
    },
    new Diagnostic
    {
        PatientId = 93,
        Name = "X-Ray",
        Result = "Normal",
        DatePerformed = DateTime.Parse("2023-10-25"),
    },
    new Diagnostic
    {
        PatientId = 30,
        Name = "ECG",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-07-07"),
    },
    new Diagnostic
    {
        PatientId = 16,
        Name = "MRI",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2021-06-24"),
    },
    new Diagnostic
    {
        PatientId = 16,
        Name = "Blood Test",
        Result = "Critical",
        DatePerformed = DateTime.Parse("2022-09-27"),
    },
    new Diagnostic
    {
        PatientId = 9,
        Name = "Blood Test",
        Result = "Abnormal",
        DatePerformed = DateTime.Parse("2023-11-15"),
    },
            };
            context.Diagnostics.AddRange(diagnostics);
            context.SaveChanges();

            var notifications = new Notification[]
            {
    new Notification
    {
        PatientId = 3,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-05-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 15,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-03-22 00:00:00"),
    },
    new Notification
    {
        PatientId = 88,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-06-24 00:00:00"),
    },
    new Notification
    {
        PatientId = 14,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-11-01 00:00:00"),
    },
    new Notification
    {
        PatientId = 64,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-11-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 77,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-05-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 43,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-01-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 14,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-07-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 55,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-10-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 87,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-06-14 00:00:00"),
    },
    new Notification
    {
        PatientId = 97,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-07-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 23,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-05-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 90,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-12-23 00:00:00"),
    },
    new Notification
    {
        PatientId = 11,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-10-25 00:00:00"),
    },
    new Notification
    {
        PatientId = 8,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-03-30 00:00:00"),
    },
    new Notification
    {
        PatientId = 86,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-05-17 00:00:00"),
    },
    new Notification
    {
        PatientId = 99,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-10-11 00:00:00"),
    },
    new Notification
    {
        PatientId = 39,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-08-19 00:00:00"),
    },
    new Notification
    {
        PatientId = 42,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-12-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 60,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-07-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 19,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-02-07 00:00:00"),
    },
    new Notification
    {
        PatientId = 21,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-08-10 00:00:00"),
    },
    new Notification
    {
        PatientId = 75,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-06-23 00:00:00"),
    },
    new Notification
    {
        PatientId = 20,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-08-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 40,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-09-09 00:00:00"),
    },
    new Notification
    {
        PatientId = 78,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-07-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 74,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-08-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 7,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-09-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 54,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-12-01 00:00:00"),
    },
    new Notification
    {
        PatientId = 50,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-05-24 00:00:00"),
    },
    new Notification
    {
        PatientId = 3,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-11-29 00:00:00"),
    },
    new Notification
    {
        PatientId = 19,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-12-18 00:00:00"),
    },
    new Notification
    {
        PatientId = 43,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-11-21 00:00:00"),
    },
    new Notification
    {
        PatientId = 34,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-11-28 00:00:00"),
    },
    new Notification
    {
        PatientId = 65,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-02-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 68,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-09-07 00:00:00"),
    },
    new Notification
    {
        PatientId = 90,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-03-24 00:00:00"),
    },
    new Notification
    {
        PatientId = 66,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-07-28 00:00:00"),
    },
    new Notification
    {
        PatientId = 70,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-02-09 00:00:00"),
    },
    new Notification
    {
        PatientId = 41,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-01-13 00:00:00"),
    },
    new Notification
    {
        PatientId = 53,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-10-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 14,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-04-22 00:00:00"),
    },
    new Notification
    {
        PatientId = 5,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-12-28 00:00:00"),
    },
    new Notification
    {
        PatientId = 64,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-04-30 00:00:00"),
    },
    new Notification
    {
        PatientId = 14,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-07-02 00:00:00"),
    },
    new Notification
    {
        PatientId = 89,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-11-29 00:00:00"),
    },
    new Notification
    {
        PatientId = 51,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-06-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 96,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-01-07 00:00:00"),
    },
    new Notification
    {
        PatientId = 30,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-02-07 00:00:00"),
    },
    new Notification
    {
        PatientId = 61,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-06-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 59,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-05-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 85,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-03-18 00:00:00"),
    },
    new Notification
    {
        PatientId = 67,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-08-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 94,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-03-06 00:00:00"),
    },
    new Notification
    {
        PatientId = 80,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-02-12 00:00:00"),
    },
    new Notification
    {
        PatientId = 1,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-10-17 00:00:00"),
    },
    new Notification
    {
        PatientId = 98,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-11-06 00:00:00"),
    },
    new Notification
    {
        PatientId = 60,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-01-10 00:00:00"),
    },
    new Notification
    {
        PatientId = 31,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-01-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 36,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-04-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 94,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-11-01 00:00:00"),
    },
    new Notification
    {
        PatientId = 31,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-03-30 00:00:00"),
    },
    new Notification
    {
        PatientId = 71,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-05-04 00:00:00"),
    },
    new Notification
    {
        PatientId = 70,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-10-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 65,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-09-29 00:00:00"),
    },
    new Notification
    {
        PatientId = 94,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-09-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 11,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-07-28 00:00:00"),
    },
    new Notification
    {
        PatientId = 70,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-06-19 00:00:00"),
    },
    new Notification
    {
        PatientId = 31,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-05-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 13,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-01-03 00:00:00"),
    },
    new Notification
    {
        PatientId = 40,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-04-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 54,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-05-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 32,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-09-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 71,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-06-01 00:00:00"),
    },
    new Notification
    {
        PatientId = 3,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-07-29 00:00:00"),
    },
    new Notification
    {
        PatientId = 5,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-11-22 00:00:00"),
    },
    new Notification
    {
        PatientId = 20,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-10-16 00:00:00"),
    },
    new Notification
    {
        PatientId = 70,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-01-11 00:00:00"),
    },
    new Notification
    {
        PatientId = 57,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-03-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 92,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-11-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 30,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-05-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 41,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-04-27 00:00:00"),
    },
    new Notification
    {
        PatientId = 43,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-12-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 65,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-07-22 00:00:00"),
    },
    new Notification
    {
        PatientId = 96,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-10-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 92,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-01-19 00:00:00"),
    },
    new Notification
    {
        PatientId = 21,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-08-12 00:00:00"),
    },
    new Notification
    {
        PatientId = 52,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-04-10 00:00:00"),
    },
    new Notification
    {
        PatientId = 69,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-08-31 00:00:00"),
    },
    new Notification
    {
        PatientId = 39,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-07-21 00:00:00"),
    },
    new Notification
    {
        PatientId = 59,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-03-06 00:00:00"),
    },
    new Notification
    {
        PatientId = 73,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-06-13 00:00:00"),
    },
    new Notification
    {
        PatientId = 40,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-06-26 00:00:00"),
    },
    new Notification
    {
        PatientId = 8,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-11-24 00:00:00"),
    },
    new Notification
    {
        PatientId = 7,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-02-20 00:00:00"),
    },
    new Notification
    {
        PatientId = 55,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-11-09 00:00:00"),
    },
    new Notification
    {
        PatientId = 93,
        Message = "Please update your info.",
        SentAt = DateTime.Parse("2023-05-05 00:00:00"),
    },
    new Notification
    {
        PatientId = 26,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-07-15 00:00:00"),
    },
    new Notification
    {
        PatientId = 15,
        Message = "Your test results are ready.",
        SentAt = DateTime.Parse("2023-03-13 00:00:00"),
    },
    new Notification
    {
        PatientId = 87,
        Message = "Appointment reminder.",
        SentAt = DateTime.Parse("2023-04-13 00:00:00"),
    },
            };
            context.Notifications.AddRange(notifications);
            context.SaveChanges();
            #endregion
        }
    }
}

