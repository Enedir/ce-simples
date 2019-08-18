using BrConselhosProva.Domain.Exceptions;
using BrConselhosProva.Domain.Features.Teachers;
using BrConselhosProva.Infra.ORM.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace BrConselhosProva.Infra.ORM.Features.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private BrConselhosProvaContext _context;
        private long _affectedRows = 0;

        public TeacherRepository(BrConselhosProvaContext context)
        {
            _context = context;
        }

        public bool Delete(Guid id)
        {
            Teacher teacher = _context.Teachers.FirstOrDefault(e => e.Id == id);

            if (teacher == null)
                throw new NotFoundException();

            _context.Entry(teacher).State = EntityState.Deleted;

            return _context.SaveChanges() > _affectedRows;
        }

        public Teacher Get(Guid id)
        {
            return _context.Teachers.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<Teacher> GetAll()
        {
            return _context.Teachers;
        }

        public Teacher Save(Teacher teacher)
        {
            if (teacher.Id == null || teacher.Id == Guid.Empty)
                teacher.Id = Guid.NewGuid();

            var newTeacher = _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return newTeacher;
        }

        public bool Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            return _context.SaveChanges() > _affectedRows;
        }
    }
}
