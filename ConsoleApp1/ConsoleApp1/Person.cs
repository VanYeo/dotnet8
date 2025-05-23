// constructor call taking year, month, date, time
// constructor
//var person = new Person
//{
//    Name = "John",
//    YearOfBirth = 1990
//}
class Person
{
    public string Name { get; set; }

    // init assigns value to property ony during object creation
    public int YearOfBirth { get; init; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}