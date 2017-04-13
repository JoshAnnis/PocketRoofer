namespace PocketRoofer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEstimateDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstimateViewModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        address = c.String(),
                        Email = c.String(),
                        bundle = c.Int(nullable: false),
                        gutter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gutters", t => t.gutter_Id)
                .Index(t => t.gutter_Id);
            
            CreateTable(
                "dbo.Gutters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Length = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstimateViewModel", "gutter_Id", "dbo.Gutters");
            DropIndex("dbo.EstimateViewModel", new[] { "gutter_Id" });
            DropTable("dbo.Gutters");
            DropTable("dbo.EstimateViewModel");
        }
    }
}
