using System.ComponentModel.DataAnnotations;

namespace PetrovGeorgeKt_43_21.Models
{
    public class TeachingLoad
    {
        public int TeachingLoadId { get; set; } // Уникальный идентификатор

        public int LabHours { get; set; } // Лабораторные часы
        public int LectureHours { get; set; } // Лекционные часы

        public int TeacherId { get; set; } // Идентификатор преподавателя
        public Teacher? Teacher { get; set; } // Навигационное свойство

        public int SubjectId { get; set; } // Идентификатор дисциплины
        public Subject? Subject { get; set; } // Навигационное свойство
    }
}
