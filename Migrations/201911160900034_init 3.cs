namespace Recipyyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "chefId", c => c.Int(nullable: false));
            AddColumn("dbo.Recipes", "cuisineId", c => c.Int(nullable: false));
            CreateIndex("dbo.Recipes", "chefId");
            CreateIndex("dbo.Recipes", "cuisineId");
            AddForeignKey("dbo.Recipes", "chefId", "dbo.Chefs", "chefId", cascadeDelete: true);
            AddForeignKey("dbo.Recipes", "cuisineId", "dbo.Cuisines", "cuisineId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "cuisineId", "dbo.Cuisines");
            DropForeignKey("dbo.Recipes", "chefId", "dbo.Chefs");
            DropIndex("dbo.Recipes", new[] { "cuisineId" });
            DropIndex("dbo.Recipes", new[] { "chefId" });
            DropColumn("dbo.Recipes", "cuisineId");
            DropColumn("dbo.Recipes", "chefId");
        }
    }
}
