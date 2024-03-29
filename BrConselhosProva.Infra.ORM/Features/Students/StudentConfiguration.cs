﻿using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Infra.ORM.Features.Students
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("TBStudent");
            Property(e => e.Id).HasColumnName("IdStudent");
            Property(e => e.Name).IsRequired();
            Property(e => e.Birthday).IsRequired();
            Property(e => e.Age).IsRequired();

        }
    }
}