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
            context.Order_Detail.AddOrUpdate(
         x => x.od_id,
         new Order_Detail { od_id = 1, p_name = "Gogoro1", od_quantity = 3551, o_id = 1},
         new Order_Detail { od_id = 2, p_name = "Gogoro1", od_quantity = 3551, o_id = 2},
         new Order_Detail { od_id = 3, p_name = "Gogoro1", od_quantity = 3551, o_id = 3},
         new Order_Detail { od_id = 4, p_name = "Gogoro1", od_quantity = 3551, o_id = 4},
         new Order_Detail { od_id = 5, p_name = "Gogoro1", od_quantity = 3551, o_id = 5},
         new Order_Detail { od_id = 6, p_name = "Gogoro1", od_quantity = 3551, o_id = 6},
         new Order_Detail { od_id = 7, p_name = "Gogoro1", od_quantity = 3551, o_id = 7},
         new Order_Detail { od_id = 8, p_name = "Gogoro1", od_quantity = 3551, o_id = 8},
         new Order_Detail { od_id = 9, p_name = "Gogoro1", od_quantity = 3551, o_id = 9},
         new Order_Detail { od_id = 10, p_name = "Gogoro1", od_quantity = 3551, o_id =10 },
         new Order_Detail { od_id = 11, p_name = "Gogoro1", od_quantity = 3551, o_id= 11 },
         new Order_Detail { od_id = 12, p_name = "Gogoro1", od_quantity = 3551, o_id =12 }
         );
        context.Orders.AddOrUpdate(
            x=>x.o_id,
            new Orders { o_id = 1, o_date = DateTime.Parse("2/1/2018") },
            new Orders { o_id = 2, o_date=DateTime.Parse("2/2/2018") },
            new Orders { o_id = 3, o_date=DateTime.Parse("2/3/2018") },
            new Orders { o_id = 4, o_date=DateTime.Parse("2/4/2018") },
            new Orders { o_id = 5, o_date=DateTime.Parse("2/5/2018") },
            new Orders { o_id = 6, o_date=DateTime.Parse("2/6/2018") },
            new Orders { o_id = 7, o_date=DateTime.Parse("2/7/2018") },
            new Orders { o_id = 8, o_date=DateTime.Parse("2/8/2018") },
            new Orders { o_id = 9, o_date=DateTime.Parse("2/9/2018") },
            new Orders { o_id = 10, o_date= DateTime.Parse("2/10/2018") },
            new Orders { o_id = 11, o_date= DateTime.Parse("2/11/2018") },
            new Orders { o_id = 12, o_date= DateTime.Parse("2/12/2018") }
            );
                
        }
    }
}
