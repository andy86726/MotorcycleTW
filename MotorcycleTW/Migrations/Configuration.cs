namespace MotorcycleTW.Migrations
{
    using MotorcycleTW.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
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
                x => x.c_id,
                new Categories { c_id = 1, c_name = "Gogoro S Perfomance" },
                new Categories { c_id = 2, c_name = "Gogoro 3 Series" },
                new Categories { c_id = 3, c_name = "Gogoro 2 Series" },
                new Categories { c_id = 4, c_name = "Gogoro 1 Series" }
                );
            context.Products.AddOrUpdate(
                x => x.p_id,
                new Products { p_id = 1, p_name = "Gogoro S1", p_unitprice = 131980, p_color_1 = "#323237", c_id = 1 },
                new Products { p_id = 2, p_name = "Gogoro S2", p_unitprice = 96980, p_color_1 = "#323237", c_id = 1 },
                new Products { p_id = 3, p_name = "Gogoro S Adventure", p_unitprice = 12880, p_color_1 = "#AA9F72", p_color_2 = "#5E6066", c_id = 1 },
                new Products { p_id = 4, p_name = "Gogoro S CafeRacer", p_unitprice = 109980, p_color_1 = "#3E2923", c_id = 1 },
                new Products { p_id = 5, p_name = "Gogoro 3", p_unitprice = 69980, p_color_1 = "#535357", p_color_2 = "#BDD2EF", c_id = 2 },
                new Products { p_id = 6, p_name = "Gogoro 3 Plus", p_unitprice = 78980, p_color_1 = "#F8E414", p_color_2 = "#F65332", c_id = 2 },
                new Products { p_id = 7, p_name = "Gogoro 2 Plus", p_unitprice = 80980, p_color_1 = "#00d7FF", p_color_2 = "#F7E300", c_id = 3 },
                new Products { p_id = 8, p_name = "Gogoro 2 Delight", p_unitprice = 844980, p_color_1 = "linear-gradient(135deg,#cda6a3,#dcbcbb,#f1dadd,#fbeaef,#e2c5c6,#cda6a3)", p_color_2 = "linear-gradient(135deg,#99a6b2,#bfc9d2,#d9dde3,#eef3f6,#d8dfe5,#b4bcc4)", c_id = 3 },
                new Products { p_id = 9, p_name = "Gogoro 2 Rumbler", p_unitprice = 87980, p_color_1 = "linear-gradient(135deg,#4f5053,#929495,#c7c8c9,#ebeced,#c6c8ca,#787c80)", c_id = 3 },
                new Products { p_id = 10, p_name = "Gogoro 1 Plus", p_unitprice = 118000, p_color_1 = "white", c_id = 3 }
                );
            context.Orders.AddOrUpdate(
                x => x.o_id,
                new Orders { o_id = 1,  o_date = DateTime.ParseExact("201801", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 2,  o_date = DateTime.ParseExact("201802", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 3,  o_date = DateTime.ParseExact("201803", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 4,  o_date = DateTime.ParseExact("201804", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 5,  o_date = DateTime.ParseExact("201805", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 6,  o_date = DateTime.ParseExact("201806", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 7,  o_date = DateTime.ParseExact("201807", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 8,  o_date = DateTime.ParseExact("201808", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 9,  o_date = DateTime.ParseExact("201809", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 10, o_date = DateTime.ParseExact("201810", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 11, o_date = DateTime.ParseExact("201811", "yyyyMM", CultureInfo.InvariantCulture) },
                new Orders { o_id = 12, o_date = DateTime.ParseExact("201812", "yyyyMM", CultureInfo.InvariantCulture) }

                );
            context.Order_Detail.AddOrUpdate(
                x => x.od_id,
                new Order_Detail { od_id = 1, p_id = 1, od_quantity = 1800, o_id = 1 },
                new Order_Detail { od_id = 2, p_id = 1, od_quantity = 1200, o_id = 2 },
                new Order_Detail { od_id = 3, p_id = 1, od_quantity = 1000, o_id = 2 },
                new Order_Detail { od_id = 4, p_id = 1, od_quantity = 1985, o_id = 2 },
                new Order_Detail { od_id = 5, p_id = 1, od_quantity = 883, o_id = 3 },
                new Order_Detail { od_id = 6, p_id = 1, od_quantity = 1200, o_id = 4 },
                new Order_Detail { od_id = 7, p_id = 1, od_quantity = 1300, o_id = 5 },
                new Order_Detail { od_id = 8, p_id = 1, od_quantity = 950, o_id = 6 },
                new Order_Detail { od_id = 9, p_id = 1, od_quantity = 862, o_id = 7 },
                new Order_Detail { od_id = 10, p_id = 1, od_quantity = 1873, o_id = 8 },
                new Order_Detail { od_id = 11, p_id = 1, od_quantity = 2851, o_id = 9 },
                new Order_Detail { od_id = 12, p_id = 1, od_quantity = 2211, o_id = 10 },
                new Order_Detail { od_id = 13, p_id = 1, od_quantity = 950, o_id = 11 },
                new Order_Detail { od_id = 14, p_id = 1, od_quantity = 862, o_id = 11 },
                new Order_Detail { od_id = 15, p_id = 1, od_quantity = 1873, o_id = 12 },
                new Order_Detail { od_id = 16, p_id = 1, od_quantity = 2851, o_id = 12 },
                new Order_Detail { od_id = 17, p_id = 1, od_quantity = 2211, o_id = 12 }
                );

        }
    }
}
