using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Application.Features.Students
{
    public interface IStudentService
    {

        bool Save(Student student);

        List<Student> GetTeachers();

        bool Delete(Guid id);


    }
}
