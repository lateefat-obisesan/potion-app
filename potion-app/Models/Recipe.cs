using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_app.Models
{
    public  class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Effect { get; set; } 
        public int Duration { get; set; }
    }
}
