namespace Recipyyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        chefId = c.Int(nullable: false, identity: true),
                        chefName = c.String(),
                    })
                .PrimaryKey(t => t.chefId);
            
            CreateTable(
                "dbo.Cookbooks",
                c => new
                    {
                        cookbookId = c.Int(nullable: false, identity: true),
                        cookbookName = c.String(),
                    })
                .PrimaryKey(t => t.cookbookId);
            
            CreateTable(
                "dbo.RecipeCookbooks",
                c => new
                    {
                        recipeId = c.Int(nullable: false),
                        cookbookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.recipeId, t.cookbookId })
                .ForeignKey("dbo.Cookbooks", t => t.cookbookId, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.recipeId, cascadeDelete: true)
                .Index(t => t.recipeId)
                .Index(t => t.cookbookId);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        recipeId = c.Int(nullable: false, identity: true),
                        recipeTitle = c.String(),
                    })
                .PrimaryKey(t => t.recipeId);
            
            CreateTable(
                "dbo.RecipeMenus",
                c => new
                    {
                        recipeId = c.Int(nullable: false),
                        menuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.recipeId, t.menuId })
                .ForeignKey("dbo.Menus", t => t.menuId, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.recipeId, cascadeDelete: true)
                .Index(t => t.recipeId)
                .Index(t => t.menuId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        menuId = c.Int(nullable: false, identity: true),
                        menuName = c.String(),
                    })
                .PrimaryKey(t => t.menuId);
            
            CreateTable(
                "dbo.RecipeTags",
                c => new
                    {
                        recipeId = c.Int(nullable: false),
                        tagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.recipeId, t.tagId })
                .ForeignKey("dbo.Recipes", t => t.recipeId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.tagId, cascadeDelete: true)
                .Index(t => t.recipeId)
                .Index(t => t.tagId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        tagId = c.Int(nullable: false, identity: true),
                        tagName = c.String(),
                    })
                .PrimaryKey(t => t.tagId);
            
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        cuisineId = c.Int(nullable: false, identity: true),
                        cuisineName = c.String(),
                    })
                .PrimaryKey(t => t.cuisineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeTags", "tagId", "dbo.Tags");
            DropForeignKey("dbo.RecipeTags", "recipeId", "dbo.Recipes");
            DropForeignKey("dbo.RecipeMenus", "recipeId", "dbo.Recipes");
            DropForeignKey("dbo.RecipeMenus", "menuId", "dbo.Menus");
            DropForeignKey("dbo.RecipeCookbooks", "recipeId", "dbo.Recipes");
            DropForeignKey("dbo.RecipeCookbooks", "cookbookId", "dbo.Cookbooks");
            DropIndex("dbo.RecipeTags", new[] { "tagId" });
            DropIndex("dbo.RecipeTags", new[] { "recipeId" });
            DropIndex("dbo.RecipeMenus", new[] { "menuId" });
            DropIndex("dbo.RecipeMenus", new[] { "recipeId" });
            DropIndex("dbo.RecipeCookbooks", new[] { "cookbookId" });
            DropIndex("dbo.RecipeCookbooks", new[] { "recipeId" });
            DropTable("dbo.Cuisines");
            DropTable("dbo.Tags");
            DropTable("dbo.RecipeTags");
            DropTable("dbo.Menus");
            DropTable("dbo.RecipeMenus");
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeCookbooks");
            DropTable("dbo.Cookbooks");
            DropTable("dbo.Chefs");
        }
    }
}
