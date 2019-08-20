namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "o_name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "o_name");
        }
    }
}
