using System.Collections.Generic;
using AutoMapper;
using StudentManagement.Application.DTOs;
using StudentManagement.Application.Interfaces;
using StudentManagement.Domain.Entities;

namespace StudentManagement.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<StudentDto> GetAllStudents()
        {
            var students = _repository.GetAllStudents();
            return _mapper.Map<List<StudentDto>>(students);
        }

        public StudentDto GetStudentById(int id)
        {
            var student = _repository.GetStudentById(id);
            return _mapper.Map<StudentDto>(student);
        }

        public void AddStudent(StudentDto studentDto)
        {
            var newStudent = _mapper.Map<Student>(studentDto);
            _repository.AddStudent(newStudent);
        }
    }
}