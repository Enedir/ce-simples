using System;
using System.Linq;

namespace BrConselhosProva.Domain.Features.Teachers
{
    public interface ITeacherRepository
    {
        bool Delete(Guid id);
        Teacher Get(Guid id);
        IQueryable<Teacher> GetAll();
        IQueryable<Teacher> GetTeacherHasStudentsWithAgeBetweenFifteenAndSeventeen();
        Teacher Save(Teacher teacher);
        bool Update(Teacher teacher);
    }
}
