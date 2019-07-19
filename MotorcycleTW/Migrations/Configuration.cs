namespace MotorcycleTW.Migrations
{
    using MotorcycleTW.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MotorcycleTW.Models.MotorcycleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MotorcycleTW.Models.MotorcycleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(
                p => p.c_id,
                new Categories { c_id = 1, c_name = "Battery" },
                new Categories { c_id = 2, c_name = "Electric_motor_car" },
                new Categories { c_id = 3, c_name = "Helment" },
                new Categories { c_id = 4, c_name = "Mat" },
                new Categories { c_id = 5, c_name = "Rear_Carrier" },
                new Categories { c_id = 6, c_name = "Fender" }
                );
        }
    }
}
