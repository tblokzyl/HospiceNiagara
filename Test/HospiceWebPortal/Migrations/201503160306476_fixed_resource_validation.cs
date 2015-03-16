namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixed_resource_validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resources", "Description", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resources", "Description", c => c.String());
        }
    }
}
