namespace PocketRoofer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedActionlink : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Gutters", name: "EstimateViewModel_Id", newName: "EstimateViewModel_Id");
            RenameIndex(table: "dbo.Gutters", name: "IX_EstimateViewModel_Id", newName: "IX_EstimateViewModel_Id");
            AlterColumn("dbo.EstimateViewModel", "bundle", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EstimateViewModel", "bundle", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Gutters", name: "IX_EstimateViewModel_Id", newName: "IX_EstimateViewModel_Id");
            RenameColumn(table: "dbo.Gutters", name: "EstimateViewModel_Id", newName: "EstimateViewModel_Id");
        }
    }
}
