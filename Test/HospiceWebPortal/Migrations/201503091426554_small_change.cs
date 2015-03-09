namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class small_change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Homes", "Title", c => c.String(maxLength: 100));
            AlterColumn("dbo.Homes", "Author", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Homes", "Author", c => c.String());
            AlterColumn("dbo.Homes", "Title", c => c.String());
        }
    }
}
