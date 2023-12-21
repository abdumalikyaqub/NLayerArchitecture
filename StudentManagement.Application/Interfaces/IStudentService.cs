using StudentManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.Interfaces
{
    public interface IStudentService
    {
        List<StudentDto> GetAllStudents();
        StudentDto GetStudentById(int id);
        void AddStudent(StudentDto studentDto);
    }
}
