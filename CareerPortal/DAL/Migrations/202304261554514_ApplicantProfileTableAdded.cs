namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicantProfileTableAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicantProfiles", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.ApplicantProfiles", "Nationality", c => c.String(nullable: false));
            AddColumn("dbo.ApplicantProfiles", "Address", c => c.String(nullable: false));
            DropTable("dbo.AdminProfiles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdminProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        username = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ApplicantProfiles", "Address");
            DropColumn("dbo.ApplicantProfiles", "Nationality");
            DropColumn("dbo.ApplicantProfiles", "Phone");
        }
    }
}
