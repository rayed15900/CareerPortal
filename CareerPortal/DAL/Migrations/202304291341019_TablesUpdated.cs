namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicantJobApplies", "ApplicantId", c => c.Int(nullable: false));
            CreateIndex("dbo.ApplicantJobApplies", "ApplicantId");
            AddForeignKey("dbo.ApplicantJobApplies", "ApplicantId", "dbo.ApplicantProfiles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicantJobApplies", "ApplicantId", "dbo.ApplicantProfiles");
            DropIndex("dbo.ApplicantJobApplies", new[] { "ApplicantId" });
            DropColumn("dbo.ApplicantJobApplies", "ApplicantId");
        }
    }
}
