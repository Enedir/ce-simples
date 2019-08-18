using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrConselhosProva.Domain.Features.Teachers;

namespace BrConselhosProva.Application.Features.Teachers
{
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public bool Delete(Guid id)
        {
            return _teacherRepository.Delete(id);
        }

        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAll().ToList();
        }

        public bool Save(Teacher teacher)
        {
            var newTeacher = _teacherRepository.Save(teacher);

            return newTeacher.Id != null;
        }
    }
}
