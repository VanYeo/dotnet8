﻿using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes
{
    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions =>
            $"Take half a teaspoon {base.PreparationInstructions}";
    }
}
