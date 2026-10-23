using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_app.Models
{
    internal class BrewRecord
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public DateTime BrewedAt { get; set; }
    }
}
