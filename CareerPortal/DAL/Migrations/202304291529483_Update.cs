﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicantProfiles", "Mail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicantProfiles", "Mail", c => c.String(nullable: false, maxLength: 30));
        }
    }
}