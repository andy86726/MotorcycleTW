namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
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
                        p_unitprice = c.Decimal(precision: 18, scale: 2),
                        c_id = c.Int(),
                        p_status = c.String(),
                        p_photo = c.String(),
                        p_stock = c.Int(),
                        p_onorder = c.Int(),
                        p_color_1 = c.String(),
                        p_color_2 = c.String(),
                    })
                .PrimaryKey(t => t.p_id)
                .ForeignKey("dbo.Categories", t => t.c_id)
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
                "dbo.Order_Detail",
                c => new
                    {
                        od_id = c.Int(nullable: false, identity: true),
                        od_quantity = c.Int(),
                        od_discount = c.Single(),
                        o_id = c.Int(),
                        p_id = c.Int(),
                    })
                .PrimaryKey(t => t.od_id)
                .ForeignKey("dbo.Orders", t => t.o_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.p_id)
                .Index(t => t.o_id)
                .Index(t => t.p_id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        o_id = c.Int(nullable: false, identity: true),
                        o_date = c.DateTime(),
                        o_receiver = c.String(),
                        o_cellphonenumber = c.Int(),
                        o_email = c.String(),
                        o_address = c.String(),
                        o_delivedate = c.DateTime(),
                        o_status = c.String(),
                        pay_id = c.Int(),
                        dw_id = c.Int(),
                        m_id = c.Int(),
                    })
                .PrimaryKey(t => t.o_id)
                .ForeignKey("dbo.Delivery_way", t => t.dw_id, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.m_id, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.pay_id)
                .Index(t => t.pay_id)
                .Index(t => t.dw_id)
                .Index(t => t.m_id);
            
            CreateTable(
                "dbo.Delivery_way",
                c => new
                    {
                        dw_id = c.Int(nullable: false, identity: true),
                        dw_way = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.dw_id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        m_id = c.Int(nullable: false, identity: true),
                        m_email = c.String(),
                        m_password = c.String(),
                        m_birthday = c.DateTime(nullable: false),
                        m_address = c.String(),
                        m_phone = c.Int(nullable: false),
                        m_identitiy = c.String(),
                        m_identitiy_number = c.String(),
                        m_zipcode = c.String(),
                        m_lastName = c.String(),
                        m_firstName = c.String(),
                        m_city = c.String(),
                        m_area = c.String(),
                        m_industry = c.String(),
                    })
                .PrimaryKey(t => t.m_id);
            
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
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shopping_Cart", "cart_id", "dbo.Products");
            DropForeignKey("dbo.Product_Picture", "p_id", "dbo.Products");
            DropForeignKey("dbo.Product_Feature", "p_id", "dbo.Products");
            DropForeignKey("dbo.Order_Detail", "p_id", "dbo.Products");
            DropForeignKey("dbo.Orders", "pay_id", "dbo.Payments");
            DropForeignKey("dbo.Order_Detail", "o_id", "dbo.Orders");
            DropForeignKey("dbo.Shopping_Cart", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "m_id", "dbo.Members");
            DropForeignKey("dbo.Orders", "dw_id", "dbo.Delivery_way");
            DropForeignKey("dbo.Classifies", "p_id", "dbo.Products");
            DropForeignKey("dbo.Products", "c_id", "dbo.Categories");
            DropForeignKey("dbo.Discounts", "c_id", "dbo.Categories");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.Product_Picture", new[] { "p_id" });
            DropIndex("dbo.Product_Feature", new[] { "p_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "m_id" });
            DropIndex("dbo.Shopping_Cart", new[] { "cart_id" });
            DropIndex("dbo.Orders", new[] { "m_id" });
            DropIndex("dbo.Orders", new[] { "dw_id" });
            DropIndex("dbo.Orders", new[] { "pay_id" });
            DropIndex("dbo.Order_Detail", new[] { "p_id" });
            DropIndex("dbo.Order_Detail", new[] { "o_id" });
            DropIndex("dbo.Classifies", new[] { "p_id" });
            DropIndex("dbo.Products", new[] { "c_id" });
            DropIndex("dbo.Discounts", new[] { "c_id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Stores");
            DropTable("dbo.Product_Picture");
            DropTable("dbo.Product_Feature");
            DropTable("dbo.Payments");
            DropTable("dbo.Shopping_Cart");
            DropTable("dbo.Members");
            DropTable("dbo.Delivery_way");
            DropTable("dbo.Orders");
            DropTable("dbo.Order_Detail");
            DropTable("dbo.Classifies");
            DropTable("dbo.Products");
            DropTable("dbo.Discounts");
            DropTable("dbo.Categories");
            DropTable("dbo.Battery_store");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
        }
    }
}
