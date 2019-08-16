using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Domain.Features.Students
{
    public interface IStudentRepository
    {
        bool Delete(Guid id);
        Student Get(Guid id);
        IQueryable<Student> GetAll();
        Student Save(Student student);
        bool Update(Student student);
    }
}
