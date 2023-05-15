namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobPost : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployerJobPosts", "ApplicationDeadline", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployerJobPosts", "ApplicationDeadline", c => c.DateTime(nullable: false));
        }
    }
}
