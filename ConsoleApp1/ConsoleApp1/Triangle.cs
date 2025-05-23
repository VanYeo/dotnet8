// constructor call taking year, month, date, time
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
