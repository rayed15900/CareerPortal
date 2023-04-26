namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicantProfiles", "UId", c => c.Int(nullable: false));
            AddColumn("dbo.ApplicantProfiles", "Education", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.ApplicantProfiles", "About", c => c.String(maxLength: 100));
            AlterColumn("dbo.ApplicantProfiles", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ApplicantProfiles", "Mail", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.ApplicantProfiles", "UId");
            AddForeignKey("dbo.ApplicantProfiles", "UId", "dbo.Users", "Id", cascadeDelete: true);
            DropTable("dbo.ApplicantManageResumes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ApplicantManageResumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.ApplicantProfiles", "UId", "dbo.Users");
            DropIndex("dbo.ApplicantProfiles", new[] { "UId" });
            AlterColumn("dbo.ApplicantProfiles", "Mail", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ApplicantProfiles", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.ApplicantProfiles", "About");
            DropColumn("dbo.ApplicantProfiles", "Education");
            DropColumn("dbo.ApplicantProfiles", "UId");
        }
    }
}
