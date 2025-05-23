// constructor call taking year, month, date, time
static class NumberToDaysOfWeekTranslator
{
    public static string Translate(int number)
    {
        return number switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => throw new ArgumentOutOfRangeException(nameof(number), "Invalid day of the week")
        };
    }
}
