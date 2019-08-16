using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Infra.ORM.Features.Teachers
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            ToTable("TBTeacher");
            Property(e => e.Id).HasColumnName("IdTeacher");
            Property(e => e.Name).IsRequired();
        }

    }
}
