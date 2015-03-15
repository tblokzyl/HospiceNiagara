namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resource_meetings_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meetings", "Name", c => c.String());
            AddColumn("dbo.Meetings", "Description", c => c.String());
            AddColumn("dbo.Meetings", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Meetings", "Location", c => c.String());
            AddColumn("dbo.Meetings", "Type", c => c.String());
            AddColumn("dbo.Meetings", "RSVP", c => c.String());
            AddColumn("dbo.Resources", "Description", c => c.String());
            AddColumn("dbo.Resources", "Name", c => c.String());
            AddColumn("dbo.Resources", "CreatedOn", c => c.String());
            AddColumn("dbo.Resources", "Data", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resources", "Data");
            DropColumn("dbo.Resources", "CreatedOn");
            DropColumn("dbo.Resources", "Name");
            DropColumn("dbo.Resources", "Description");
            DropColumn("dbo.Meetings", "RSVP");
            DropColumn("dbo.Meetings", "Type");
            DropColumn("dbo.Meetings", "Location");
            DropColumn("dbo.Meetings", "Date");
            DropColumn("dbo.Meetings", "Description");
            DropColumn("dbo.Meetings", "Name");
        }
    }
}
