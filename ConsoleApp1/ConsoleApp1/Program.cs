// constructor call taking year, month, date, time
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

var pizza = new Pizza();

// calls constructor of base class first with argument of 12
var cheddar = new Cheddar(2, 12);



// Example usage of GetCountsOfAnimalsLegs
var legsCounts = GetCountsOfAnimalsLegs();
Console.WriteLine("Animal legs counts: " + string.Join(", ", legsCounts));

// Remove duplicate AddIngredient method from Pizza class

public class Pizza
{
    // Only one field for ingredients
    private readonly List<Ingredient> ingredients = new List<Ingredient>();

    // Only one AddIngredient method
    public void AddIngredient(Ingredient ingredient) =>
        ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {string.Join(",", ingredients.Select(i => i.GetType().Name))}";
}

// can be left empty if no shared properties/methods
public class Ingredient
{
    public Ingredient(int priceIfExtraTopping
    {
        Console.WriteLine(
            "Constructor from the Ingredient class");
        priceIfExtraTopping = priceIfExtraTopping;
    }

    publix int PriceIfExtraTopping { get; }

    public override string ToString() => ;

    public virtual string Name { get; } = "Some ingredient";

    public int PublicField; 
    // inherited by all ingredients
    public string PublicMethod() =>
        "This method is public in ingredient class";

    // not inherited by other ingredients
    private string PrivateMethod() =>
         "This method is private in ingredient class";
}

// inheritance: suggesting cheddar and tomato sauce are ingredients
public class Cheddar : Ingredient
{
    public Cheddar(int PriceIfExtraTopping, int agedForMonths) : base(PriceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }

    public int PriceIfExtraTopping { get; }
    public override string Name => $"{base.Name}, more specifically, a cheddar cheese aged for {AgedForMonths}";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}