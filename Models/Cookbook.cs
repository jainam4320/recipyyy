using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Cookbook
    {
        public int cookbookId { get; set; }
        public string cookbookName { get; set; }

        public virtual ICollection<RecipeCookbook> recipeCookbookList { get; set; }
    }
}