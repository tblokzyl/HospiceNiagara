namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullablephone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.Long(nullable: false));
        }
    }
}
