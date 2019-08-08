namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_MemberTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "m_lastName", c => c.String());
            AddColumn("dbo.Members", "m_firstName", c => c.String());
            AddColumn("dbo.Members", "m_city", c => c.String());
            AddColumn("dbo.Members", "m_area", c => c.String());
            DropColumn("dbo.Members", "m_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "m_name", c => c.String());
            DropColumn("dbo.Members", "m_area");
            DropColumn("dbo.Members", "m_city");
            DropColumn("dbo.Members", "m_firstName");
            DropColumn("dbo.Members", "m_lastName");
        }
    }
}
