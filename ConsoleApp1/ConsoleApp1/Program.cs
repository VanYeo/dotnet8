// constructor call taking year, month, date, time
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Linq;
using System.Collections.Generic;
using ConsoleApp1.Extensions;

var pizza = new Pizza();

var multiLineText = @"aaa
bbb
ccc
ddd";

int CountLines(string input) =>
    input.Split(Environment.NewLine).Length;

var ingredient = new Ingredient(5);

Console.WriteLine(multiLineText.CountLines);

// is operator checks if the object is of a specific type
Console.WriteLine($"Is object: {ingredient is object}");
Console.WriteLine($"Is object {ingredient is Ingredient}");
Console.WriteLine($"Is object {ingredient is Cheddar}");

// calls constructor of base class first with argument of 12
var cheddar = new Cheddar(2, 12);

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
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine(
            "Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient";

    // no point adding method as will be overriden in derived classes
    public abstract void Prepare();

    public int PublicField;
    // inherited by all ingredients
    public string PublicMethod() =>
        "This method is public in ingredient class";

    // not inherited by other ingredients
    private string PrivateMethod() =>
         "This method is private in ingredient class";
}

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Cheese class");
    }
}

// inheritance: suggesting cheddar and tomato sauce are ingredients
public class Cheddar : Cheese
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }

    public override string Name => $"{base.Name}, more specifically, a cheddar cheese aged for {AgedForMonths}";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}

// sealed class prevents further inheritance
public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping, int waterContent) : base(priceIfExtraTopping)
    {
        
    }
    public override string Name => "Mozzarella";
    public bool IsLight { get; }

    public override void Prepare()
    {
        Console.WriteLine("Slice thinly and place on top of the pizza");
    }
}
public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping, int tomatoesIn100Grams)
        : base(priceIfExtraTopping)
    {
        TomatoesIn100Grams = tomatoesIn100Grams;
    }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

//your code goes here - define the Shape class
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }

    //your code goes here
    public override double CalculateArea()
    {
        return Side * Side;
    }


public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    //your code goes here
    public override double CalculateArea()
    {
        return Width * Height;
        }
    }

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    //your code goes here'
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
