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

        public List<Potion> GetPotions()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Potions.OrderByDescending(x => x.BrewedAt).ToList();
            }
        }

        public void AddIngredient(Ingredient ingredient)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Ingredients.Add(ingredient);
                db.SaveChanges();
            }
        }

        public void UpdateStock(int id, int stock)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Ingredient ingredient = db.Ingredients.Find(id);

                if (ingredient == null)
                    throw new Exception("Ingredient was not found.");

                if (stock < 0)
                    throw new Exception("Stock cannot be negative.");

                ingredient.Stock = stock;
                db.SaveChanges();
            }
        }

        public void RetireIngredient(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                bool used = db.RecipeIngredients
                    .Any(x => x.IngredientId == id);

                if (used)
                    throw new Exception(
                        "This ingredient belongs to a recipe and cannot be retired.");

                Ingredient ingredient = db.Ingredients.Find(id);

                if (ingredient != null)
                {
                    db.Ingredients.Remove(ingredient);
                    db.SaveChanges();
                }
            }
        }

        public void ConsumePotion(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Potion potion = db.Potions.Find(id);

                if (potion != null)
                {
                    db.Potions.Remove(potion);
                    db.SaveChanges();
                }
            }
        }
    }
}
