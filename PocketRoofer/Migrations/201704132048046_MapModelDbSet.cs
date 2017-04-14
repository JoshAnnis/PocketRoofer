namespace PocketRoofer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MapModelDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MapModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Zoom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MapModels");
        }
    }
}
