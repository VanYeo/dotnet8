// constructor call taking year, month, date, time
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

    // computed
    public int CalculateArea() => Width * _height;

    public int CalculateCircumference() => 2 * (Width + _height);

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
