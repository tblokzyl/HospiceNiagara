namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Announcements", "Title", c => c.String(maxLength: 100));
            AlterColumn("dbo.Announcements", "Content", c => c.String());
            AlterColumn("dbo.Announcements", "Author", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Announcements", "Author", c => c.String(maxLength: 30));
            AlterColumn("dbo.Announcements", "Content", c => c.String(maxLength: 30));
            AlterColumn("dbo.Announcements", "Title", c => c.String(maxLength: 30));
        }
    }
}
