// constructor call taking year, month, date, time
using System.Drawing;

var IntPizzaDay = new DateTime(2023, 3, 14);

var rectangle1 = new Rectangle(5, 10);
var triangle1 = new Triangle(5, 10);
var dog1 = new Dog("Max", 10, "Labrador");
dog1.Describe();
//Console.WriteLine(triangle1.AsString());


//Console.WriteLine($"Width is {rectangle1.Width}");
//Console.WriteLine($"Height is {rectangle1.Height}");
//Console.WriteLine($"Area is {rectangle1.CalculateArea()}");
//Console.WriteLine($"Area is {rectangle1.CalculateArea()}");
class Rectangle
{
    // fields: variable like
    public readonly int Width;
    private int _height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(Height));
    }

    public int GetHeight() => _height;

    // properties: fields but with getters and setters
    public int Width1 { get; private set; }
    public void SetHeight(int height)
    {
        _height = GetLengthOrDefault(height, nameof(Height));
    }

    private int GetLengthOrDefault(int length, string name)
    {
        if (length < 0)
        {
            Console.WriteLine($"Invalid {name} value. Setting to default value of 1.");
            return 1;
        }
        return length;
    } 
}

class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }
}

class Triangle
{
    public int Base;

    public int Height;
    public Triangle(int @base, int height)
    {
        Base = @base;
        Height = height;    
    }

    public double CalculateArea()
    {
        return (Base * Height) / 2; 
    }

    public string AsString()
    {
               return $"Base is {Base}, height is {Height}";
    }
}

class Dog
{
    public string Name;
    public int Weight;
    public string Breed;
    public Dog(string name, int weight, string breed)
    {
        Name = name;
        Weight = weight;
        Breed = breed;    
    }
    public Dog(string name, int weight)
        : this(name, weight, "mixed-breed")
    {
    }
    
    public string WeightDescription()
    {
        return Weight switch
        {
            < 5 => "tiny",
            > 5 and < 30 => "medium",
            _ => "large"
        };
    }
    public void Describe()
    {
        Console.WriteLine($"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {WeightDescription()} dog");
    }
}


class Order
{

    public int Item { get; }
    public DateTime @DateTime { get; set; }
}