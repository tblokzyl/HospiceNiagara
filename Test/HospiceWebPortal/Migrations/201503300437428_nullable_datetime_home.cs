namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable_datetime_home : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Homes", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Homes", "Created", c => c.DateTime(nullable: false));
        }
    }
}
