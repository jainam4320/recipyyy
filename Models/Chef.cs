using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Chef
    {
        public int chefId { get; set;}
        public string chefName { get; set; }

        public ICollection<Recipe> recipes { get; set; }

    }
}