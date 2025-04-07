using System.ComponentModel.DataAnnotations;

namespace Health_Care_appointment_system_API.Models
{
    public class Patients
    {
        [Key]
        public Guid Id {get; set;}
        public required string Name {get; set;}
        public DateTime DOB {get; set;}
        public required string ContactInfo {get; set;}
        public required string Medical_History {get; set;}
        public required DateTime[] Appointments {get; set;}
    }
}