using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Health_Care_appointment_system_API.Models
{


public enum AppointmentStatus
{
    Scheduled,
    Completed,
    Cancelled,
    Rescheduled,
    NoShow
}


    public class Appointments
    {
        [Key]
        public Guid Id {get; set;}
        public required string Patient {get; set;}
        // public int DoctorId {get; set;}
        // public required string Doctors Doctors {get; set;}
         public required List<DateTime> Date { get; set; } = new();
         public required string Reason {get; set;}

         public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    }

    public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
        : base(options)
    {
    }

    public DbSet<Appointments> Appointments { get; set; }

    // Add OnModelCreating method
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Appointments>()
            .Property(a => a.Status)
            .HasConversion<string>(); // Enum saved as string in SQL Server
    }
}

}