namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resource_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "FileContent", c => c.Binary(nullable: false));
            AddColumn("dbo.Resources", "MimeType", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Resources", "FileName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Meetings", "Description", c => c.String(maxLength: 1000));
            DropColumn("dbo.Resources", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "Data", c => c.Byte(nullable: false));
            AlterColumn("dbo.Meetings", "Description", c => c.String(maxLength: 500));
            DropColumn("dbo.Resources", "FileName");
            DropColumn("dbo.Resources", "MimeType");
            DropColumn("dbo.Resources", "FileContent");
        }
    }
}
