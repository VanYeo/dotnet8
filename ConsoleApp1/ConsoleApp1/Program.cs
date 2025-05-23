// constructor call taking year, month, date, time
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

var IntPizzaDay = new DateTime(2023, 3, 14);

var rectangle1 = new Rectangle(5, 10);
var triangle1 = new Triangle(5, 10);
var dog1 = new Dog("Max", 10, "Labrador");
dog1.Describe();

Console.WriteLine(Calculator.Add(1, 3));

var pizza = new Pizza();

// Moved top-level statements before type declarations
bool shallAddPositiveOnly = true;
if (shallAddPositiveOnly)
{
    var numbers = new List<int> { 1, -2, 3, 4, -5 };
    var calculator = new PositiveNumbersSumCalculator();
    int positiveSum = calculator.Calculate(numbers);
    Console.WriteLine($"Sum of positive numbers: {positiveSum}");
}

// Local function instead of invalid static method
List<int> GetCountsOfAnimalsLegs()
{
    var animals = new List<Animal>
    {
        new Lion(),
        new Tiger(),
        new Duck(),
        new Spider()
    };

    var result = new List<int>();
    foreach (var animal in animals)
    {
        result.Add(animal.NumberOfLegs);
    }
    return result;
}

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
    public string Name => "Cheddar cheese";
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

public class PositiveNumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}

public class Animal
{
    // Default number of legs is 4
    public virtual int NumberOfLegs => 4;
}

public class Lion : Animal
{
    // Inherits NumberOfLegs = 4 from Animal
}

public class Tiger : Animal
{
    // Inherits NumberOfLegs = 4 from Animal
}

public class Duck : Animal
{
    // Override to return 2 legs
    public override int NumberOfLegs => 2;
}

public class Spider : Animal
{
    // Override to return 8 legs
    public override int NumberOfLegs => 8;
}