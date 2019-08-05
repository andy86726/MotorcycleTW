namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_members : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "m_industry", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "m_industry");
        }
    }
}
