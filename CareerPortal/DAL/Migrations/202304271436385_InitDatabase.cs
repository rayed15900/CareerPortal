namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicantProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Mail = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false),
                        Nationality = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Education = c.String(nullable: false, maxLength: 100),
                        About = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: false)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployerJobPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Description = c.String(nullable: false, maxLength: 200),
                        Type = c.String(nullable: false, maxLength: 20),
                        Salary = c.Int(nullable: false),
                        Location = c.String(nullable: false, maxLength: 20),
                        RequiredSkills = c.String(nullable: false, maxLength: 200),
                        EducationLevel = c.String(nullable: false, maxLength: 200),
                        Experience = c.String(nullable: false, maxLength: 20),
                        ApplicationDeadline = c.DateTime(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 20),
                        CompanyMail = c.String(nullable: false),
                        Employer_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManageCategories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerProfiles", t => t.Employer_Id, cascadeDelete: false)
                .Index(t => t.Employer_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.AppliedJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobId, cascadeDelete: false)
                .Index(t => t.ApplicantId)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.ManageCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Nationality = c.String(nullable: false, maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.EmployerRecruitments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Shortlist = c.Boolean(nullable: false),
                        Employer_Id = c.Int(nullable: false),
                        Applicant_Id = c.Int(nullable: false),
                        JobPost_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.Applicant_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobPost_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerProfiles", t => t.Employer_Id, cascadeDelete: false)
                .Index(t => t.Employer_Id)
                .Index(t => t.Applicant_Id)
                .Index(t => t.JobPost_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployerRecruitments", "Employer_Id", "dbo.EmployerProfiles");
            DropForeignKey("dbo.EmployerRecruitments", "JobPost_Id", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.EmployerRecruitments", "Applicant_Id", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.EmployerJobPosts", "Employer_Id", "dbo.EmployerProfiles");
            DropForeignKey("dbo.EmployerProfiles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.EmployerJobPosts", "Category_Id", "dbo.ManageCategories");
            DropForeignKey("dbo.AppliedJobs", "JobId", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.AppliedJobs", "ApplicantId", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ApplicantProfiles", "UId", "dbo.Users");
            DropIndex("dbo.EmployerRecruitments", new[] { "JobPost_Id" });
            DropIndex("dbo.EmployerRecruitments", new[] { "Applicant_Id" });
            DropIndex("dbo.EmployerRecruitments", new[] { "Employer_Id" });
            DropIndex("dbo.EmployerProfiles", new[] { "User_Id" });
            DropIndex("dbo.AppliedJobs", new[] { "JobId" });
            DropIndex("dbo.AppliedJobs", new[] { "ApplicantId" });
            DropIndex("dbo.EmployerJobPosts", new[] { "Category_Id" });
            DropIndex("dbo.EmployerJobPosts", new[] { "Employer_Id" });
            DropIndex("dbo.ApplicantProfiles", new[] { "UId" });
            DropTable("dbo.EmployerRecruitments");
            DropTable("dbo.EmployerProfiles");
            DropTable("dbo.ManageCategories");
            DropTable("dbo.AppliedJobs");
            DropTable("dbo.EmployerJobPosts");
            DropTable("dbo.Users");
            DropTable("dbo.ApplicantProfiles");
        }
    }
}
