using BrConselhosProva.Application.Features.Students;
using BrConselhosProva.Application.Features.Teachers;
using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Domain.Features.Teachers;
using BrConselhosProva.Infra.ORM.Context;
using BrConselhosProva.Infra.ORM.Features.Students;
using BrConselhosProva.Infra.ORM.Features.Teachers;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace BrConselhosProva.WebApp.Containers
{
    public static class SimpleInjectorContainer
    {
        public static Container ContainerInstance { get; private set; }
        public static void Initializer()
        {
            ContainerInstance = new Container();
            ContainerInstance.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
          
            Registers();

            ContainerInstance.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            ContainerInstance.RegisterMvcIntegratedFilterProvider();
            ContainerInstance.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(ContainerInstance));
        }
        public static void Registers()
        {
            ContainerInstance.Register<ITeacherService, TeacherService>();
            ContainerInstance.Register<IStudentService, StudentService>();
            ContainerInstance.Register<ITeacherRepository, TeacherRepository>();
            ContainerInstance.Register<IStudentRepository, StudentRepository>();

            var connectionString = ConfigurationManager.ConnectionStrings["BrConselhos_Estudante"].ConnectionString;

            ContainerInstance.Register(() => new BrConselhosProvaContext(connectionString), Lifestyle.Scoped);
        }
    }
}