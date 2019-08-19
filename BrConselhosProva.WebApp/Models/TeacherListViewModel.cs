using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Models
{
    public class TeacherListViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }

}