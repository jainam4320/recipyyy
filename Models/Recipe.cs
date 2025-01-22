using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Recipe
    {
        public int recipeId { get; set; }
        public string recipeTitle { get; set; }

        public int chefId { get; set; }
        public Chef chef { get; set; }

        public int cuisineId { get; set; }
        public Cuisine cusine { get; set; }

        public virtual ICollection<RecipeCookbook> recipeCookbookList { get; set; }
        public virtual ICollection<RecipeMenu> recipeMenuListP { get; set; }
        public virtual ICollection<RecipeTag> recipeTag { get; set; }
    }
}