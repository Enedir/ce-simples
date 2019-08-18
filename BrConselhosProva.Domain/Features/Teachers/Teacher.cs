using BrConselhosProva.Domain.Features.Students;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrConselhosProva.Domain.Features.Teachers
{
    public class Teacher
    {
        public Teacher() { }

        public Teacher(string name, List<Student> students)
        {
            Name = name;
            Students = students;
        }

        public Guid Id { get; set; }
        public string Name { get; set;  }
        public virtual ICollection<Student> Students { get; set; }


        public int StudentsCount
        {
            get
            {
                return Students.Count();
            }
        }
    }
}
