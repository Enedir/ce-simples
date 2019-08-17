using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrConselhosProva.WebApp.Models
{
    public class StudentCreateViewModel
    {

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Display(Name = "Nome:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório.")]
        [Display(Name = "Date de Nascimento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "O campo professor é obrigatório.")]
        [Display(Name = "Professor:")]
        public Guid TeacherId { get; set; }
    }
}