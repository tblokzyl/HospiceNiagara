namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Meetings", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Meetings", "Date", c => c.DateTime(nullable: false));
        }
    }
}
