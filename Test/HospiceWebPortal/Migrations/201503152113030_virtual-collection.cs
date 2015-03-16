
namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class virtualcollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Announcements", "Contact_ID", c => c.Int());
            AddColumn("dbo.Announcements", "Home_ID", c => c.Int());
            AddColumn("dbo.Announcements", "Meeting_ID", c => c.Int());
            AddColumn("dbo.Announcements", "Schedule_ID", c => c.Int());
            AddColumn("dbo.Resources", "Announcement_ID", c => c.Int());
            AddColumn("dbo.Resources", "Contact_ID", c => c.Int());
            AddColumn("dbo.Resources", "Home_ID", c => c.Int());
            AddColumn("dbo.Resources", "Meeting_ID", c => c.Int());
            AddColumn("dbo.Resources", "Schedule_ID", c => c.Int());
            CreateIndex("dbo.Announcements", "Contact_ID");
            CreateIndex("dbo.Announcements", "Home_ID");
            CreateIndex("dbo.Announcements", "Meeting_ID");
            CreateIndex("dbo.Announcements", "Schedule_ID");
            CreateIndex("dbo.Resources", "Announcement_ID");
            CreateIndex("dbo.Resources", "Contact_ID");
            CreateIndex("dbo.Resources", "Home_ID");
            CreateIndex("dbo.Resources", "Meeting_ID");
            CreateIndex("dbo.Resources", "Schedule_ID");
            AddForeignKey("dbo.Resources", "Announcement_ID", "dbo.Announcements", "ID");
            AddForeignKey("dbo.Announcements", "Contact_ID", "dbo.Contacts", "ID");
            AddForeignKey("dbo.Resources", "Contact_ID", "dbo.Contacts", "ID");
            AddForeignKey("dbo.Announcements", "Home_ID", "dbo.Homes", "ID");
            AddForeignKey("dbo.Resources", "Home_ID", "dbo.Homes", "ID");
            AddForeignKey("dbo.Announcements", "Meeting_ID", "dbo.Meetings", "ID");
            AddForeignKey("dbo.Resources", "Meeting_ID", "dbo.Meetings", "ID");
            AddForeignKey("dbo.Announcements", "Schedule_ID", "dbo.Schedules", "ID");
            AddForeignKey("dbo.Resources", "Schedule_ID", "dbo.Schedules", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resources", "Schedule_ID", "dbo.Schedules");
            DropForeignKey("dbo.Announcements", "Schedule_ID", "dbo.Schedules");
            DropForeignKey("dbo.Resources", "Meeting_ID", "dbo.Meetings");
            DropForeignKey("dbo.Announcements", "Meeting_ID", "dbo.Meetings");
            DropForeignKey("dbo.Resources", "Home_ID", "dbo.Homes");
            DropForeignKey("dbo.Announcements", "Home_ID", "dbo.Homes");
            DropForeignKey("dbo.Resources", "Contact_ID", "dbo.Contacts");
            DropForeignKey("dbo.Announcements", "Contact_ID", "dbo.Contacts");
            DropForeignKey("dbo.Resources", "Announcement_ID", "dbo.Announcements");
            DropIndex("dbo.Resources", new[] { "Schedule_ID" });
            DropIndex("dbo.Resources", new[] { "Meeting_ID" });
            DropIndex("dbo.Resources", new[] { "Home_ID" });
            DropIndex("dbo.Resources", new[] { "Contact_ID" });
            DropIndex("dbo.Resources", new[] { "Announcement_ID" });
            DropIndex("dbo.Announcements", new[] { "Schedule_ID" });
            DropIndex("dbo.Announcements", new[] { "Meeting_ID" });
            DropIndex("dbo.Announcements", new[] { "Home_ID" });
            DropIndex("dbo.Announcements", new[] { "Contact_ID" });
            DropColumn("dbo.Resources", "Schedule_ID");
            DropColumn("dbo.Resources", "Meeting_ID");
            DropColumn("dbo.Resources", "Home_ID");
            DropColumn("dbo.Resources", "Contact_ID");
            DropColumn("dbo.Resources", "Announcement_ID");
            DropColumn("dbo.Announcements", "Schedule_ID");
            DropColumn("dbo.Announcements", "Meeting_ID");
            DropColumn("dbo.Announcements", "Home_ID");
            DropColumn("dbo.Announcements", "Contact_ID");
        }
    }
}
