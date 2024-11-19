using System.ComponentModel.DataAnnotations;

namespace PetrovGeorgeKt_43_21.Models
{
    public class Subject
    {
        public int SubjectId { get; set; } 

        public string? Name { get; set; } 

        public int Hours { get; set; } 
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
