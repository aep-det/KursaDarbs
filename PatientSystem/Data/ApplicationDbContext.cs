using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }

    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }

    public class Professional
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        public string Specialization { get; set; } = null!;

        public ICollection<Appointment>? Appointments { get; set; }
    }

    public class Appointment
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        [ForeignKey("Professional")]
        public int ProfessionalId { get; set; }
        public Professional? Professional { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // Only one definition for Time and Status, properly initialized
        public string Time { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    public class MedicalRecord
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string Diagnosis { get; set; } = null!;
        public string Treatment { get; set; } = null!;
        public string Prescription { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }

    public class Diagnostic
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string Name { get; set; } = null!;
        public string Result { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime DatePerformed { get; set; }
    }

    public class Medication
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string Name { get; set; } = null!;
        public string Dosage { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
    }

    public class Notification
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string Message { get; set; } = null!;

        [DataType(DataType.DateTime)]
        public DateTime SentAt { get; set; }
    }
}
