namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Order_Detail", new[] { "o_id" });
            DropIndex("dbo.Order_Detail", new[] { "p_id" });
            DropIndex("dbo.Orders", new[] { "dw_id" });
            DropIndex("dbo.Orders", new[] { "m_id" });
            AlterColumn("dbo.Order_Detail", "od_quantity", c => c.Int());
            AlterColumn("dbo.Order_Detail", "od_discount", c => c.Single());
            AlterColumn("dbo.Order_Detail", "o_id", c => c.Int());
            AlterColumn("dbo.Order_Detail", "p_id", c => c.Int());
            AlterColumn("dbo.Orders", "o_date", c => c.DateTime());
            AlterColumn("dbo.Orders", "o_cellphonenumber", c => c.Int());
            AlterColumn("dbo.Orders", "o_delivedate", c => c.DateTime());
            AlterColumn("dbo.Orders", "pay_id", c => c.Int());
            AlterColumn("dbo.Orders", "dw_id", c => c.Int());
            AlterColumn("dbo.Orders", "m_id", c => c.Int());
            CreateIndex("dbo.Order_Detail", "o_id");
            CreateIndex("dbo.Order_Detail", "p_id");
            CreateIndex("dbo.Orders", "pay_id");
            CreateIndex("dbo.Orders", "dw_id");
            CreateIndex("dbo.Orders", "m_id");
            AddForeignKey("dbo.Orders", "pay_id", "dbo.Payments", "pay_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "pay_id", "dbo.Payments");
            DropIndex("dbo.Orders", new[] { "m_id" });
            DropIndex("dbo.Orders", new[] { "dw_id" });
            DropIndex("dbo.Orders", new[] { "pay_id" });
            DropIndex("dbo.Order_Detail", new[] { "p_id" });
            DropIndex("dbo.Order_Detail", new[] { "o_id" });
            AlterColumn("dbo.Orders", "m_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "dw_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "pay_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "o_delivedate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "o_cellphonenumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "o_date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Order_Detail", "p_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Order_Detail", "o_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Order_Detail", "od_discount", c => c.Single(nullable: false));
            AlterColumn("dbo.Order_Detail", "od_quantity", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "m_id");
            CreateIndex("dbo.Orders", "dw_id");
            CreateIndex("dbo.Order_Detail", "p_id");
            CreateIndex("dbo.Order_Detail", "o_id");
        }
    }
}
