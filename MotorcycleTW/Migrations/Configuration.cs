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
                new Products { p_id = 10, p_name = "Gogoro 1 Plus", p_unitprice = 118000, p_color_1 = "white" },
                new Products { p_id = 11, p_name = "後置物架＆行李箱組", p_unitprice = 4680 }
                );
            context.Product_Reminders.AddOrUpdate(
                x => x.pr_id,
                new Product_Reminders { pr_id = 1, p_id = 11, pr_detail = "Gogoro S2 Adventure 及 Gogoro S2 Adventure Tour Edition 已有標配 Gogoro 2 後置架。" },
                new Product_Reminders { pr_id = 2, p_id = 11, pr_detail = "套件組內之各項產品之特性及應注意事項，請詳閱各商品頁之溫馨提醒。" },
                new Product_Reminders { pr_id = 3, p_id = 11, pr_detail = "本套件組適用於 Gogoro 2 系列全車款及 Gogoro S2 系列全車款。" },
                new Product_Reminders { pr_id = 4, p_id = 11, pr_detail = "Gogoro 2 後製物架限重 5 kg、 SHAD 行李箱 原廠限重 3 公斤，請注意勿超過承重範圍。" },
                new Product_Reminders { pr_id = 5, p_id = 11, pr_detail = "SHAD 行李箱為輕量塑膠材質所製，洗車時請先將箱體由快拆拆除，避免高壓水柱直接沖擊箱體造成損傷。" },
                new Product_Reminders { pr_id = 5, p_id = 11, pr_detail = "專業安裝服務需酌收安裝費。" }
                );
            context.Product_Picture.AddOrUpdate(
                x => x.pp_id,
                new Product_Picture { pp_id = 1, p_id = 11, pp_path = "/Assets/images/Product/%e5%be%8c%e7%bd%ae%e7%89%a9%e6%9e%b6%ef%bc%86%e8%a1%8c%e6%9d%8e%e7%ae%b1%e7%b5%84.jpg" }
                );
            context.Product_Feature.AddOrUpdate(
                x => x.pf_id,
                new Product_Feature { pf_id = 1, p_id = 11, pf_note = "『延伸置物，輕鬆滿載』", pf_description = "後製物架採精選堅固耐用鐵製材質，搭配黑色霧面烤漆，為一兼具設計、實用、堅固的承載檯面。後行李箱可輕鬆放入一頂全罩式的安全帽，或是兩頂四分之三罩安全帽。置物空間的延伸讓收納更方便，每趟出行都可完備無虞。" }
                );

        }
    }
}
