using System.Runtime.CompilerServices;

var cookiesRecipesApp = new CookiesRecipesApp();
cookiesRecipesApp.Run();

// class to manage workflow of implementation
public class CookiesRecipesApp
{
    private readonly RecipesRepository _recipesRepository;
    private readonly RecipesUserInteraction _recipesUserInteraction;
    
    public CookiesRecipesApp(
        RecipesRepository recipesRepository,
        RecipesUserInteraction recipesConsoleUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesConsoleUserInteraction;
    }
    public void Run()
    {
        // retrieve all recipes 
        var allRecipes = _recipesRepository.Read(filePath);

        // print all recipes to user
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        // prompt user to create a new recipe
        _recipesUserInteraction.PromptToCreateRecipe();

        // read ingredients from user input
        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count > 0)
        {
            // create a new recipe with the provided ingredients
            var recipes = new Recipe(ingredients);

            // add the new recipe to the existing recipes
            allRecipes.Add(recipes);

            // save the updated recipes to the repository
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage(
                "Recipe has been saved successfully! ");
            _recipesUserInteraction.ShowMessage(recipes.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected, " + "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
}

