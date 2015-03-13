namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contacts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Contacts", "Position", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Contacts", "Phone", c => c.Long(nullable: false));
            AddColumn("dbo.Contacts", "EXT", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "EXT");
            DropColumn("dbo.Contacts", "Phone");
            DropColumn("dbo.Contacts", "Position");
            DropColumn("dbo.Contacts", "LastName");
            DropColumn("dbo.Contacts", "FirstName");
        }
    }
}
