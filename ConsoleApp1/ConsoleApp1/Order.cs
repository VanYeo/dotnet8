// constructor call taking year, month, date, time
class Order
{
    public int Item { get; }
    private DateTime _date; // This is the backing field

    public DateTime Date
    {
        get => _date; // Getter returns the backing field's value
        set
        {
            // Setter can include validation or logic
            if (value.Year == DateTime.Now.Year)
                _date = value;
            // else: ignore or handle invalid value
        }
    }
}
