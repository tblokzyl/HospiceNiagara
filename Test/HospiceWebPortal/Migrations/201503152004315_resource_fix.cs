namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resource_fix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resources", "CreatedOn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Resources", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "Name", c => c.String());
            AlterColumn("dbo.Resources", "CreatedOn", c => c.String());
        }
    }
}
