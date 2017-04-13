namespace PocketRoofer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApplicationDbContextToSaveEstimate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EstimateViewModel", "gutter_Id", "dbo.Gutters");
            DropIndex("dbo.EstimateViewModel", new[] { "gutter_Id" });
            AddColumn("dbo.Gutters", "EstimateViewModel_Id", c => c.Int());
            CreateIndex("dbo.Gutters", "EstimateViewModel_Id");
            AddForeignKey("dbo.Gutters", "EstimateViewModel_Id", "dbo.EstimateViewModel", "Id");
            DropColumn("dbo.EstimateViewModel", "gutter_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EstimateViewModel", "gutter_Id", c => c.Int());
            DropForeignKey("dbo.Gutters", "EstimateViewModel_Id", "dbo.EstimateViewModel");
            DropIndex("dbo.Gutters", new[] { "EstimateViewModel_Id" });
            DropColumn("dbo.Gutters", "EstimateViewModel_Id");
            CreateIndex("dbo.EstimateViewModel", "gutter_Id");
            AddForeignKey("dbo.EstimateViewModel", "gutter_Id", "dbo.Gutters", "Id");
        }
    }
}
