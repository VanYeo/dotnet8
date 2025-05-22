// constructor call taking year, month, date, time
var IntPizzaDay = new DateTime(2023, 3, 14);

var rectangle1 = new Rectangle(5, 10);
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

