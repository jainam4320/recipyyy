using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Tag
    {
        public int tagId { get; set; }
        public string tagName { get; set; }

        public ICollection<RecipeTag> recipeTag { get; set; }
    }
}