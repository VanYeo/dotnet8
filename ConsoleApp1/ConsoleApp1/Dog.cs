// constructor call taking year, month, date, time
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
