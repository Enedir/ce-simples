using AutoMapper;
using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Profiles
{
    public class StudentToStudentListViewModel : Profile
    {

        public StudentToStudentListViewModel()
        {
            CreateMap<Student, StudentListViewModel>()
               .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
               .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
               .ForMember(vm => vm.Birthday, map => map.MapFrom(m => m.Birthday.ToString("dd/MM/yyyy")))
               .ForMember(vm => vm.TeacherName, map => map.MapFrom(m => m.Teacher.Name));
        }

    }
}