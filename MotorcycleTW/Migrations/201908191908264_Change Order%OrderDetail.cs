namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOrderOrderDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order_Detail", "od_carnumber", c => c.String());
            AddColumn("dbo.Order_Detail", "od_carname", c => c.String());
            AddColumn("dbo.Order_Detail", "od_price", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order_Detail", "od_price");
            DropColumn("dbo.Order_Detail", "od_carname");
            DropColumn("dbo.Order_Detail", "od_carnumber");
        }
    }
}
