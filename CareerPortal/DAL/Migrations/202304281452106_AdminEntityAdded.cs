namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminEntityAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManageJobPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.ManageUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantID = c.Int(nullable: false),
                        EmployerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantID, cascadeDelete: true)
                .ForeignKey("dbo.EmployerProfiles", t => t.EmployerID, cascadeDelete: true)
                .Index(t => t.ApplicantID)
                .Index(t => t.EmployerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManageUsers", "EmployerID", "dbo.EmployerProfiles");
            DropForeignKey("dbo.ManageUsers", "ApplicantID", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ManageJobPosts", "JobId", "dbo.EmployerJobPosts");
            DropIndex("dbo.ManageUsers", new[] { "EmployerID" });
            DropIndex("dbo.ManageUsers", new[] { "ApplicantID" });
            DropIndex("dbo.ManageJobPosts", new[] { "JobId" });
            DropTable("dbo.ManageUsers");
            DropTable("dbo.ManageJobPosts");
        }
    }
}
