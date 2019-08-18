using AutoMapper;
using BrConselhosProva.WebApp.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrConselhosProva.WebApp.Containers
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<TeacherToTeacherListViewModel>();
                x.AddProfile<StudentToStudentListViewModel>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}