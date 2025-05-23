// constructor call taking year, month, date, time
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
    // public access modifier allows global access
    // public vars should start w capital letters
    public int Width;
    public int Height;

    // constructor that assigns values of params to fields
    // must be named same as class name + no return type
    // cannnot be called like a method in other contexts
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;    
    }
    
    public int CalculateCircumference()
    {
        return 2 * (Width + Height);
    }

    public int CalculateArea()
    {
        return Width * Height;
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
