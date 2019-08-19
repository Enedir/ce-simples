namespace BrConselhosProva.Infra.ORM.Migrations
{
    using BrConselhosProva.Domain.Features.Students;
    using BrConselhosProva.Domain.Features.Teachers;
    using BrConselhosProva.Infra.ORM.Context;
    using BrConselhosProva.Infra.ORM.Features.Students;
    using BrConselhosProva.Infra.ORM.Features.Teachers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrConselhosProvaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BrConselhosProvaContext context)
        {
            var teacherRespotory = new TeacherRepository(context);

            var teacherOne = new Teacher()
            {
                Name = "Carlos da Silva",
            };

            var teacherTwo = new Teacher()
            {
                Name = "Ana Paula",
            };

            teacherOne = teacherRespotory.Save(teacherOne);
            teacherTwo = teacherRespotory.Save(teacherTwo);

            var studentReposiotry = new StudentRepository(context);

            var studantOne = new Student()
            {
                Name = "José da silva",
                Birthday = DateTime.Parse("2002-05-05"),
                Age = 17,
                TeacherId = teacherOne.Id
            };

            var studantTwo = new Student()
            {
                Name = "Gustava de Abril",
                Birthday = DateTime.Parse("2007-05-14"),
                Age = 12,
                TeacherId = teacherTwo.Id
            };

            var studantThree = new Student()
            {
                Name = "Vanessa da luz",
                Birthday = DateTime.Parse("2010-05-16"),
                Age = 9,
                TeacherId = teacherOne.Id
            };

            studentReposiotry.Save(studantOne);
            studentReposiotry.Save(studantTwo);
            studentReposiotry.Save(studantThree);

            base.Seed(context);
        }
    }
}
