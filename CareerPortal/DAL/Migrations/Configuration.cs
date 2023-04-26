namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.CPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.CPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //for(int i=1; i<=10;  i++)
            //{
            //    context.users.addorupdate(new models.user
            //    {
            //        username = guid.newguid().tostring().substring(0, 10),
            //        password = guid.newguid().tostring().substring(0, 6),
            //        type = "general"
            //    });
            //}
        }
    }
}
