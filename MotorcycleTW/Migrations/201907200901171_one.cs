namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
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
                "dbo.Products",
                c => new
                    {
                        p_id = c.Int(nullable: false, identity: true),
                        p_name = c.String(),
                        p_unitprice = c.Decimal(precision: 18, scale: 2),
                        c_id = c.Int(),
                        p_status = c.String(),
                        p_photo = c.String(),
                        p_stock = c.Int(),
                        p_color = c.String(maxLength: 50),
                        p_onorder = c.Int(),
                    })
                .PrimaryKey(t => t.p_id);
            
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
            
            CreateTable(
                "dbo.Shopping_Cart",
                c => new
                    {
                        cart_id = c.Int(nullable: false),
                        m_id = c.Int(nullable: false),
                        p_id = c.Int(nullable: false),
                        cart_quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cart_id)
                .ForeignKey("dbo.Members", t => t.m_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.cart_id)
                .Index(t => t.cart_id)
                .Index(t => t.m_id);
            
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
                .ForeignKey("dbo.Delivery_way", t => t.dw_id, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.m_id, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.pay_id, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.Delive_Way_s_id)
                .Index(t => t.pay_id)
                .Index(t => t.dw_id)
                .Index(t => t.m_id)
                .Index(t => t.Delive_Way_s_id);
            
            CreateTable(
                "dbo.Delivery_way",
                c => new
                    {
                        dw_id = c.Int(nullable: false, identity: true),
                        dw_way = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.dw_id);
            
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
                .Index(t => t.o_id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        pay_id = c.Int(nullable: false, identity: true),
                        pay_name = c.String(),
                    })
                .PrimaryKey(t => t.pay_id);
            
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
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shopping_Cart", "cart_id", "dbo.Products");
            DropForeignKey("dbo.Shopping_Cart", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "Delive_Way_s_id", "dbo.Stores");
            DropForeignKey("dbo.Orders", "pay_id", "dbo.Payments");
            DropForeignKey("dbo.Order_Detail", "o_id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "dw_id", "dbo.Delivery_way");
            DropForeignKey("dbo.Product_Picture", "p_id", "dbo.Products");
            DropForeignKey("dbo.Product_Feature", "p_id", "dbo.Products");
            DropForeignKey("dbo.Classifies", "p_id", "dbo.Products");
            DropForeignKey("dbo.Discounts", "c_id", "dbo.Categories");
            DropIndex("dbo.Order_Detail", new[] { "o_id" });
            DropIndex("dbo.Orders", new[] { "Delive_Way_s_id" });
            DropIndex("dbo.Orders", new[] { "m_id" });
            DropIndex("dbo.Orders", new[] { "dw_id" });
            DropIndex("dbo.Orders", new[] { "pay_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "m_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "cart_id" });
            DropIndex("dbo.Product_Picture", new[] { "p_id" });
            DropIndex("dbo.Product_Feature", new[] { "p_id" });
            DropIndex("dbo.Classifies", new[] { "p_id" });
            DropIndex("dbo.Discounts", new[] { "c_id" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Stores");
            DropTable("dbo.Payments");
            DropTable("dbo.Order_Detail");
            DropTable("dbo.Delivery_way");
            DropTable("dbo.Orders");
            DropTable("dbo.Members");
            DropTable("dbo.Shopping_Cart");
            DropTable("dbo.Product_Picture");
            DropTable("dbo.Product_Feature");
            DropTable("dbo.Products");
            DropTable("dbo.Classifies");
            DropTable("dbo.Discounts");
            DropTable("dbo.Categories");
            DropTable("dbo.Battery_store");
        }
    }
}
