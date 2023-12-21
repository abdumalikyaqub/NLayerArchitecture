using System;


namespace StudentManagement.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string? Citizenship { get; set; }

        public string? Nationality { get; set; }

        public string? PassportData { get; set; }

        public string? PhoneNumber { get; set; }

        public string? MaritalStatus { get; set; }

        public string? FormOfStudy { get; set; }

        public string? BasisOfStudy { get; set; }
        // Добавьте другие необходимые данные
    }
}
