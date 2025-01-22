namespace Recipyyy.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RecipyyyContext : DbContext
    {
        // Your context has been configured to use a 'RecipyyyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Recipyyy.Models.RecipyyyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RecipyyyContext' 
        // connection string in the application configuration file.
        public RecipyyyContext()
            : base("name=RecipyyyContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Recipe> recipe { get; set; }
        public virtual DbSet<Chef> chef { get; set; }
        public virtual DbSet<Cuisine> cuisine { get; set; }
        public virtual DbSet<Cookbook> cookbook { get; set; }
        public virtual DbSet<Menu> menu { get; set; }
        public virtual DbSet<Tag> tag { get; set; }

        public virtual DbSet<RecipeCookbook> recipeCookbook { get; set; }
        public virtual DbSet<RecipeMenu> recipeMenu { get; set; }
        public virtual DbSet<RecipeTag> recipeTag { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}