using System.ComponentModel.DataAnnotations;

namespace PetrovGeorgeKt_43_21.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; } 

        public decimal Rate { get; set; } // Ставка

        public string Degree { get; set; } // Степень

        public string Title { get; set; } // Звание

        public string Position { get; set; } // Должность
    }
}
