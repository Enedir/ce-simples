using BrConselhosProva.Domain.Features.Students;
using System;
using System.Collections.Generic;


namespace BrConselhosProva.Domain.Features.Teachers
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set;  }
        public virtual List<Student> Students { get; set; }

        public Teacher(){}

        public Teacher(string name, List<Student> students)
        {
            Name = name;
            Students = students;
        }
    }
}
