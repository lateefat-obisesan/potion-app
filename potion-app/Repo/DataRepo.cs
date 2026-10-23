using potion_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_app.Repo
{
    public class DataRepo
    {
        private static List<Ingredient> ingredients = new List<Ingredient>();
        private static List<Recipe> recipes = new List<Recipe>();
        private static List<Potion> potions = new List<Potion>();

        public List<Ingredient> GetIngredients()
        {
            return ingredients.OrderBy(x => x.Name).ToList();
        }

        public List<Recipe> GetRecipes()
        {
            return recipes.OrderBy(x => x.Name).ToList();
        }

        public List<Potion> GetPotions()
        {
            return potions.OrderByDescending(x => x.BrewedAt).ToList();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            ingredient.Id = ingredients.Count + 1;
            ingredients.Add(ingredient);
        }

        public void UpdateStock(int id, int stock)
        {
            Ingredient ingredient = ingredients.FirstOrDefault(x => x.Id == id);

            if (ingredient == null)
                throw new Exception("Ingredient was not found.");

            if (stock < 0)
                throw new Exception("Stock cannot be negative.");

            ingredient.Stock = stock;
        }

        public void RetireIngredient(int id)
        {
            Ingredient ingredient = ingredients.FirstOrDefault(x => x.Id == id);

            if (ingredient == null)
                return;

            ingredients.Remove(ingredient);
        }

        public void AddRecipe(Recipe recipe)
        {
            recipe.Id = recipes.Count + 1;
            recipes.Add(recipe);
        }

        public void AddPotion(Potion potion)
        {
            potion.Id = potions.Count + 1;
            potions.Add(potion);
        }

        public void ConsumePotion(int id)
        {
            Potion potion = potions.FirstOrDefault(x => x.Id == id);

            if (potion != null)
                potions.Remove(potion);
        }
    }
}
