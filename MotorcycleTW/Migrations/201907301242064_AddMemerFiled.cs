namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemerFiled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "m_identitiy", c => c.String());
            AddColumn("dbo.Members", "m_phone", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "m_identitiy_number", c => c.String());
            AddColumn("dbo.Members", "m_address", c => c.String());
            AddColumn("dbo.Members", "m_zipcode", c => c.String());
            AddColumn("dbo.Members", "m_birthday", c => c.DateTime(nullable: false));
            DropColumn("dbo.Members", "Identitiy");
            DropColumn("dbo.Members", "Phone");
            DropColumn("dbo.Members", "Identitiy_number");
            DropColumn("dbo.Members", "Address");
            DropColumn("dbo.Members", "Zipcode");
            DropColumn("dbo.Members", "birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "Zipcode", c => c.String());
            AddColumn("dbo.Members", "Address", c => c.String());
            AddColumn("dbo.Members", "Identitiy_number", c => c.String());
            AddColumn("dbo.Members", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "Identitiy", c => c.String());
            DropColumn("dbo.Members", "m_birthday");
            DropColumn("dbo.Members", "m_zipcode");
            DropColumn("dbo.Members", "m_address");
            DropColumn("dbo.Members", "m_identitiy_number");
            DropColumn("dbo.Members", "m_phone");
            DropColumn("dbo.Members", "m_identitiy");
        }
    }
}
