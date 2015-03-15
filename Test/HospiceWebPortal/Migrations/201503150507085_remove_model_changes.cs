namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_model_changes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Description", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
