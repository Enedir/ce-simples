using BrConselhosProva.Domain.Features.Students;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace BrConselhosProva.Domain.Tests
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void Students_Domian_GetAge_ShouldBeOk()
        {
            //Cenário
            var student = new Student("Aluno", new DateTime(1994, 5, 16));
            int expectedAge = 25;

            //Ação
            int age = student.GetAge;

            //Saída
            age.Should().Be(expectedAge);
        }
    }
}
