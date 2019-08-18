using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrConselhosProva.Domain.Features.Students;

namespace BrConselhosProva.Application.Features.Students
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool Delete(Guid id)
        {
            return _studentRepository.Delete(id);
        }

        public List<Student> GetTeachers()
        {
            return _studentRepository.GetAll().ToList();
        }

        public bool Save(Student student)
        {
            student.GetAge();

            var newStudent = _studentRepository.Save(student);

            return newStudent.Id != null;
        }
    }
}
