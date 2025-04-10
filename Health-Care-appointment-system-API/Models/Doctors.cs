using System.ComponentModel.DataAnnotations;

namespace Health_Care_appointment_system_API.Models
{
    public class Doctors
    {
        [Key]
        public Guid Id {get; set;}
        public required string Name {get; set;}
        public required string[] Specialities {get; set;}
        public required List<DateTime> Availability { get; set; } = new();

        public required string Bio {get; set;}
        public required string Location {get; set;}
    }
}