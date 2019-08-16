using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Domain.Features.Students
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Student(){}

        public Student(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public int GetAge
        {
            get { return Convert.ToInt32((( DateTime.Now - Birthday.Date).TotalDays) / 365); }
        }

    }
}
