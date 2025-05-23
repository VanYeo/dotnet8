// constructor call taking year, month, date, time
public class Pizza
{
    // use list to allow manipulation of items
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => 
        _ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {string.Join(",", _ingredients)}";
}
