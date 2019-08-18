using AutoMapper;
using BrConselhosProva.Domain.Features.Teachers;
using BrConselhosProva.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Profiles
{
    public class TeacherToTeacherListViewModel : Profile
    {
        public TeacherToTeacherListViewModel()
        {
            CreateMap<Teacher, TeacherListViewModel>()
                .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
                .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name));
        }
    }
}