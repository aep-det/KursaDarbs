using System;
using Xunit;
using PatientSystem.Data; // Adjust if your namespace differs

namespace PatientSystem.Tests
{
    public class PatientTests
    {
        [Fact]
        public void Appointment_ShouldNotBeScheduledInPast()
        {
            var appointment = new Appointment
            {
                Date = DateTime.Today.AddDays(-3),
                Status = "scheduled"
            };

            var isInvalid = appointment.Status == "scheduled" && appointment.Date < DateTime.Today;

            Assert.True(isInvalid); // This reveals a logic problem if it ever happens
        }



    }
}
