using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Citizenship { get; set; }
        public string Nationality { get; set; }
        public string PassportData { get; set; }
        public string PhoneNumber { get; set; }
        public string MaritalStatus { get; set; }
        public string FormOfStudy { get; set; }
        public string BasisOfStudy { get; set; }
        // Добавьте другие необходимые данные
    }
}
