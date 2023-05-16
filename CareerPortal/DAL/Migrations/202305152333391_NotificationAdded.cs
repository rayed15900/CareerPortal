namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotificationAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false, maxLength: 100),
                        ApplicantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .Index(t => t.ApplicantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "ApplicantId", "dbo.ApplicantProfiles");
            DropIndex("dbo.Notifications", new[] { "ApplicantId" });
            DropTable("dbo.Notifications");
        }
    }
}
