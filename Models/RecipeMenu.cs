using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class RecipeMenu
    {
        [Key, Column(Order = 1)]
        public int recipeId { get; set; }
        [Key, Column(Order = 2)]
        public int menuId { get; set; }

        public Recipe recipe { get; set; }
        public Menu menu { get; set; }
    }
}