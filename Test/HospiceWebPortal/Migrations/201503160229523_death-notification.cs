namespace HospiceWebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deathnotification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeathNotifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Date = c.DateTime(nullable: true),
                        Location = c.String(maxLength: 100),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DeathNotifications");
        }
    }
}
