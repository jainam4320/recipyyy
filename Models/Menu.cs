using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Menu
    {
        public int menuId { get; set; }
        public string menuName { get; set; }

        public virtual ICollection<RecipeMenu> recipeMenuList { get; set; }

    }
}