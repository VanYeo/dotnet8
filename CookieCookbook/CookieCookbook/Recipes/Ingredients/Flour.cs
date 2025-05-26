using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes
{
    public abstract class Flour : Ingredient
    {
        // base takes the string defined in base string
        public override string PreparationInstructions =>
            $"Sift. {base.PreparationInstructions}";
    }
}
