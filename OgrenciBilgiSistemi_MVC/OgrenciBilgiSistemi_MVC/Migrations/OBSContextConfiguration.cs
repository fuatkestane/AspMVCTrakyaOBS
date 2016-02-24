using OgrenciBilgiSistemi_MVC.Repositories;
using System.Data.Entity.Migrations;

namespace OgrenciBilgiSistemi_MVC.Migrations
{
    internal sealed class OBSContextConfiguration : DbMigrationsConfiguration<OBSContext>
    {
        public OBSContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OBSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }

}