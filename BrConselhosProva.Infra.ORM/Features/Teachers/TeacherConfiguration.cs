using BrConselhosProva.Domain.Features.Students;
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

            HasMany<Student>(g => g.Students)
           .WithRequired(s => s.Teacher)
           .HasForeignKey<Guid>(s => s.TeacherId)
           .WillCascadeOnDelete();
        }

    }
}
