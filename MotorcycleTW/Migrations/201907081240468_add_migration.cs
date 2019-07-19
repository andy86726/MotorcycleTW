namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Battery_store",
                c => new
                    {
                        s_id = c.Int(nullable: false, identity: true),
                        s_name = c.String(),
                        s_block = c.String(),
                        s_address = c.String(),
                    })
                .PrimaryKey(t => t.s_id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        c_id = c.Int(nullable: false, identity: true),
                        c_name = c.String(),
                    })
                .PrimaryKey(t => t.c_id);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        d_id = c.Int(nullable: false, identity: true),
                        d_discount = c.Single(nullable: false),
                        d_startdate = c.DateTime(nullable: false),
                        d_enddate = c.DateTime(nullable: false),
                        c_id = c.Int(nullable: false),
                        d_activity = c.String(),
                    })
                .PrimaryKey(t => t.d_id)
                .ForeignKey("dbo.Categories", t => t.c_id, cascadeDelete: true)
                .Index(t => t.c_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        p_id = c.Int(nullable: false, identity: true),
                        p_name = c.String(),
                        p_unitprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        p_lauchdate = c.DateTime(nullable: false),
                        c_id = c.Int(nullable: false),
                        p_status = c.String(),
                    })
                .PrimaryKey(t => t.p_id)
                .ForeignKey("dbo.Categories", t => t.c_id, cascadeDelete: true)
                .Index(t => t.c_id);

            CreateTable(
                "dbo.Classifies",
                c => new
                    {
                        cl_id = c.Int(nullable: false, identity: true),
                        cl_specs = c.String(),
                        cl_content = c.String(),
                        p_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cl_id)
                .ForeignKey("dbo.Products", t => t.p_id, cascadeDelete: true)
                .Index(t => t.p_id);
            
            CreateTable(
                "dbo.Delivery_way",
                c => new
                    {
                        dw_id = c.Int(nullable: false, identity: true),
                        dw_way = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.dw_id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        o_id = c.Int(nullable: false, identity: true),
                        o_date = c.DateTime(nullable: false),
                        o_receiver = c.String(),
                        o_cellphonenumber = c.Int(nullable: false),
                        o_email = c.String(),
                        o_address = c.String(),
                        o_delivedate = c.DateTime(nullable: false),
                        o_status = c.String(),
                        pay_id = c.Int(nullable: false),
                        dw_id = c.Int(nullable: false),
                        m_id = c.Int(nullable: false),
                        Delive_Way_s_id = c.Int(),
                    })
                .PrimaryKey(t => t.o_id)
                .ForeignKey("dbo.Stores", t => t.Delive_Way_s_id)
                .ForeignKey("dbo.Members", t => t.m_id, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.pay_id, cascadeDelete: true)
                .ForeignKey("dbo.Delivery_way", t => t.dw_id, cascadeDelete: true)
                .Index(t => t.pay_id)
                .Index(t => t.dw_id)
                .Index(t => t.m_id)
                .Index(t => t.Delive_Way_s_id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        s_id = c.Int(nullable: false, identity: true),
                        s_name = c.String(),
                        s_block = c.String(),
                        s_address = c.String(),
                    })
                .PrimaryKey(t => t.s_id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        m_id = c.Int(nullable: false, identity: true),
                        m_name = c.String(),
                        m_email = c.String(),
                        m_password = c.String(),
                    })
                .PrimaryKey(t => t.m_id);
            
            CreateTable(
                "dbo.Shopping_Cart",
                c => new
                    {
                        cart_id = c.Int(nullable: false, identity: true),
                        m_id = c.Int(nullable: false),
                        pd_id = c.Int(nullable: false),
                        cart_quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cart_id)
                .ForeignKey("dbo.Members", t => t.m_id, cascadeDelete: true)
                .ForeignKey("dbo.Product_Detail", t => t.pd_id, cascadeDelete: true)
                .Index(t => t.m_id)
                .Index(t => t.pd_id);
            
            CreateTable(
                "dbo.Order_Detail",
                c => new
                    {
                        od_id = c.Int(nullable: false, identity: true),
                        od_quantity = c.Int(nullable: false),
                        od_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        od_discount = c.Single(nullable: false),
                        o_id = c.Int(nullable: false),
                        pd_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.od_id)
                .ForeignKey("dbo.Orders", t => t.o_id, cascadeDelete: true)
                .ForeignKey("dbo.Product_Detail", t => t.pd_id, cascadeDelete: true)
                .Index(t => t.o_id)
                .Index(t => t.pd_id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        pay_id = c.Int(nullable: false, identity: true),
                        pay_name = c.String(),
                    })
                .PrimaryKey(t => t.pay_id);
            
            CreateTable(
                "dbo.Product_Feature",
                c => new
                    {
                        pf_id = c.Int(nullable: false, identity: true),
                        pf_description = c.String(),
                        pf_note = c.String(),
                        p_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pf_id)
                .ForeignKey("dbo.Products", t => t.p_id, cascadeDelete: true)
                .Index(t => t.p_id);
            
            CreateTable(
                "dbo.Product_Picture",
                c => new
                    {
                        pp_id = c.Int(nullable: false, identity: true),
                        pp_path = c.String(),
                        pp_uploadtime = c.DateTime(nullable: false),
                        p_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pp_id)
                .ForeignKey("dbo.Products", t => t.p_id, cascadeDelete: true)
                .Index(t => t.p_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_Picture", "p_id", "dbo.Products");
            DropForeignKey("dbo.Product_Feature", "p_id", "dbo.Products");
            DropForeignKey("dbo.Orders", "dw_id", "dbo.Delivery_way");
            DropForeignKey("dbo.Orders", "pay_id", "dbo.Payments");
            DropForeignKey("dbo.Order_Detail", "pd_id", "dbo.Product_Detail");
            DropForeignKey("dbo.Order_Detail", "o_id", "dbo.Orders");
            DropForeignKey("dbo.Shopping_Cart", "pd_id", "dbo.Product_Detail");
            DropForeignKey("dbo.Shopping_Cart", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "Delive_Way_s_id", "dbo.Stores");
            DropForeignKey("dbo.Classifies", "p_id", "dbo.Products");
            DropForeignKey("dbo.Products", "c_id", "dbo.Categories");
            DropForeignKey("dbo.Product_Detail", "p_id", "dbo.Products");
            DropForeignKey("dbo.Discounts", "c_id", "dbo.Categories");
            DropIndex("dbo.Product_Picture", new[] { "p_id" });
            DropIndex("dbo.Product_Feature", new[] { "p_id" });
            DropIndex("dbo.Order_Detail", new[] { "pd_id" });
            DropIndex("dbo.Order_Detail", new[] { "o_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "pd_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "m_id" });
            DropIndex("dbo.Orders", new[] { "Delive_Way_s_id" });
            DropIndex("dbo.Orders", new[] { "m_id" });
            DropIndex("dbo.Orders", new[] { "dw_id" });
            DropIndex("dbo.Orders", new[] { "pay_id" });
            DropIndex("dbo.Classifies", new[] { "p_id" });
            DropIndex("dbo.Product_Detail", new[] { "p_id" });
            DropIndex("dbo.Products", new[] { "c_id" });
            DropIndex("dbo.Discounts", new[] { "c_id" });
            DropTable("dbo.Product_Picture");
            DropTable("dbo.Product_Feature");
            DropTable("dbo.Payments");
            DropTable("dbo.Order_Detail");
            DropTable("dbo.Shopping_Cart");
            DropTable("dbo.Members");
            DropTable("dbo.Stores");
            DropTable("dbo.Orders");
            DropTable("dbo.Delivery_way");
            DropTable("dbo.Classifies");
            DropTable("dbo.Product_Detail");
            DropTable("dbo.Products");
            DropTable("dbo.Discounts");
            DropTable("dbo.Categories");
            DropTable("dbo.Battery_store");
        }
    }
}
