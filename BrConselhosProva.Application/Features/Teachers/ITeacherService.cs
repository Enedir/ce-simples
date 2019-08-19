using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Application.Features.Teachers
{
    public interface ITeacherService
    {
        bool Save(Teacher teacher);

        List<Teacher> GetTeachers();

        bool Delete(Guid id);
        List<Teacher> GetFilterTeacher();
    }
}
