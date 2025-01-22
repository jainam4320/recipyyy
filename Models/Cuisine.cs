using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipyyy.Models
{
    public class Cuisine
    {
        public int cuisineId { get; set; }
        public string cuisineName { get; set; }

        public ICollection<Recipe> recipes { get; set; }
    }
}