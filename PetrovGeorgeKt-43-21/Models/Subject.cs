using System.ComponentModel.DataAnnotations;

namespace PetrovGeorgeKt_43_21.Models
{
    public class Subject
    {
        public int SubjectId { get; set; } // Уникальный идентификатор

        public string? Name { get; set; } // Название дисциплины

        public int LabHours { get; set; } // Лабораторные часы
        public int LectureHours { get; set; } // Лекционные часы
    }
}
