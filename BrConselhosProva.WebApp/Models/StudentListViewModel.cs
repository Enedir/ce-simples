using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Models
{
    public class StudentListViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Date de Nascimento")]
        public String Birthday { get; set; }

        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Display(Name = "Professor")]
        public string TeacherName { get; set; }


    }
}