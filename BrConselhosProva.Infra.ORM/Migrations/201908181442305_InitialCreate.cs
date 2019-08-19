namespace BrConselhosProva.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBStudent",
                c => new
                    {
                        IdStudent = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        TeacherId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdStudent)
                .ForeignKey("dbo.TBTeacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.TBTeacher",
                c => new
                    {
                        IdTeacher = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdTeacher);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBStudent", "TeacherId", "dbo.TBTeacher");
            DropIndex("dbo.TBStudent", new[] { "TeacherId" });
            DropTable("dbo.TBTeacher");
            DropTable("dbo.TBStudent");
        }
    }
}
