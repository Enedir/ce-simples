using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Domain.Features.Teachers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrConselhosProva.Infra.ORM.Context
{
    public class BrConselhosProvaContext : DbContext
    {
        public BrConselhosProvaContext() : base("BrConselhos_Estudante")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected BrConselhosProvaContext(DbConnection connection) : base(connection, true) { }

        public BrConselhosProvaContext(string connectionStringName) : base(string.Format("name={0}", connectionStringName)) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
