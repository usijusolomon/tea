namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrate3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.Long(nullable: false, identity: true),
                        QuestionId = c.Long(nullable: false),
                        QuestionAnswer = c.String(),
                        RightAnswer = c.Boolean(nullable: false),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: false)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Long(nullable: false, identity: true),
                        CourseId = c.Long(nullable: false),
                        AskedQuestion = c.String(),
                        QuestionNumber = c.Int(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        UserPassword = c.String(),
                        ConfirmPassword = c.String(),
                        UserMatric = c.String(),
                        UserFirstName = c.String(),
                        UserLastName = c.String(),
                        UserType = c.String(),
                        LevelId = c.Long(nullable: false),
                        DepartmentId = c.Long(nullable: false),
                        FacultyId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: false)
                .ForeignKey("dbo.Levels", t => t.LevelId, cascadeDelete: false)
                .Index(t => t.LevelId)
                .Index(t => t.DepartmentId)
                .Index(t => t.FacultyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "LevelId", "dbo.Levels");
            DropForeignKey("dbo.Users", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "CourseId", "dbo.Courses");
            DropIndex("dbo.Users", new[] { "FacultyId" });
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.Users", new[] { "LevelId" });
            DropIndex("dbo.Questions", new[] { "CourseId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.Users");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
