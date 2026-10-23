using potion_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_app.Repo
{
    public class AppRepo
    {
        public List<Ingredient> GetIngredients()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Ingredients.OrderBy(x => x.Name).ToList();
            }
        }

        public List<Recipe> GetRecipes()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Recipes.OrderBy(x => x.Name).ToList();
            }
        }
    }
}
