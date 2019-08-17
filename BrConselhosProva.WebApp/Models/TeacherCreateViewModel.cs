using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Models
{
    public class TeacherCreateViewModel
    {
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Display(Name = "Nome:")]
        public string Name { get; set; }
    }
}