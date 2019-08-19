using BrConselhosProva.Domain.Exceptions;
using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Infra.ORM.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace BrConselhosProva.Infra.ORM.Features.Students
{
    public class StudentRepository : IStudentRepository
    {

        private BrConselhosProvaContext _context;
        private long _affectedRows = 0;

        public StudentRepository(BrConselhosProvaContext context)
        {
            _context = context;
        }

        public bool Delete(Guid id)
        {
            Student student = _context.Students.FirstOrDefault(e => e.Id == id);

            if (student == null)
                throw new NotFoundException();

            _context.Entry(student).State = EntityState.Deleted;

            return _context.SaveChanges() > _affectedRows;
        }

        public Student Get(Guid id)
        {
            return _context.Students.Where(c => c.Id == id)
                                    .Include(x => x.Teacher)
                                    .FirstOrDefault();
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Students.Include(x => x.Teacher);
        }

        public IQueryable<Student> GetStudentThatHasAgeBiggestThenSixteen()
        {
            return _context.Students.Include(x => x.Teacher).Where(x => x.Age >= 16);
        }

        public Student Save(Student student)
        {
            if (student.Id == null || student.Id == Guid.Empty)
                student.Id = Guid.NewGuid();

            var newstudent = _context.Students.Add(student);
            _context.SaveChanges();

            return newstudent;
        }

        public bool Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            return _context.SaveChanges() > _affectedRows;
        }
    }
}
