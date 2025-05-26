using System.ComponentModel;

namespace CookieCookbook.Recipes
{
    // wrapper for collection of Ingredients
    public class Recipes
    {
        // having public list is not ideal even if there is only getter hence user Enumerable
        // e.g. calling recipe.Ingredients.Clear() would clear the list
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipes(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
