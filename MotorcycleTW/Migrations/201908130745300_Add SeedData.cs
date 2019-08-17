namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product_Reminders",
                c => new
                    {
                        pr_id = c.Int(nullable: false, identity: true),
                        pr_detail = c.String(),
                        p_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pr_id)
                .ForeignKey("dbo.Products", t => t.p_id, cascadeDelete: true)
                .Index(t => t.p_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_Reminders", "p_id", "dbo.Products");
            DropIndex("dbo.Product_Reminders", new[] { "p_id" });
            DropTable("dbo.Product_Reminders");
        }
    }
}
