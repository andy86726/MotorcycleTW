namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product_Picture", "pp_uploadtime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product_Picture", "pp_uploadtime", c => c.DateTime(nullable: false));
        }
    }
}
