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
                new Products { p_id = 11, p_name = "��m���[������c��", p_unitprice = 4680 }
                );
            context.Product_Reminders.AddOrUpdate(
                x => x.pr_id,
                new Product_Reminders { pr_id = 1, p_id = 11, pr_detail = "Gogoro S2 Adventure �� Gogoro S2 Adventure Tour Edition �w���аt Gogoro 2 ��m�[�C" },
                new Product_Reminders { pr_id = 2, p_id = 11, pr_detail = "�M��դ����U�����~���S�ʤ����`�N�ƶ��A�иԾ\�U�ӫ~�������ɴ����C" },
                new Product_Reminders { pr_id = 3, p_id = 11, pr_detail = "���M��վA�Ω� Gogoro 2 �t�C�����ڤ� Gogoro S2 �t�C�����ڡC" },
                new Product_Reminders { pr_id = 4, p_id = 11, pr_detail = "Gogoro 2 ��s���[���� 5 kg�B SHAD ����c ��t���� 3 ����A�Ъ`�N�ŶW�L�ӭ��d��C" },
                new Product_Reminders { pr_id = 5, p_id = 11, pr_detail = "SHAD ����c�����q�콦����һs�A�~���ɽХ��N�c��ѧ֩��A�קK�������W�����R���c��y���l�ˡC" },
                new Product_Reminders { pr_id = 5, p_id = 11, pr_detail = "�M�~�w�˪A�Ȼݰu���w�˶O�C" }
                );
            context.Product_Picture.AddOrUpdate(
                x => x.pp_id,
                new Product_Picture { pp_id = 1, p_id = 11, pp_path = "/Assets/images/Product/%e5%be%8c%e7%bd%ae%e7%89%a9%e6%9e%b6%ef%bc%86%e8%a1%8c%e6%9d%8e%e7%ae%b1%e7%b5%84.jpg" }
                );
            context.Product_Feature.AddOrUpdate(
                x => x.pf_id,
                new Product_Feature { pf_id = 1, p_id = 11, pf_note = "�y�����m���A���P�����z", pf_description = "��s���[�ĺ���T�@���K�s����A�f�t�¦������N���A���@�ݨ�]�p�B��ΡB��T���Ӹ��i���C�����c�i���P��J�@�����n�����w���U�A�άO�⳻�|�����T�n�w���U�C�m���Ŷ������������ǧ��K�A�C��X�泣�i���ƵL���C" }
                );

        }
    }
}
