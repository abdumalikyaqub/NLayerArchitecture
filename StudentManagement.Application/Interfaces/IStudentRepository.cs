using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;


namespace StudentManagement.Application.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
    }
}
