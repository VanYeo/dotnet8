Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Input the second number:");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string choice = Console.ReadLine();

if (EqualsCaseInsensitive(choice, "M"))
    {
        PrintFinalEquation(number1, number2, "+", number1 + number2);
    }
    else if (EqualsCaseInsensitive(choice, "A"))
    {
        PrintFinalEquation(number1, number2, "+", number1 + number2);
    }
    else if (EqualsCaseInsensitive(choice, "S"))
    {
        PrintFinalEquation(number1, number2, "-", number1 - number2);
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }

void PrintFinalEquation(
    int number1,
    int number2,
    string @operator, //@ to bypass operator keyword
    int result)
{
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}

bool EqualsCaseInsensitive(string str1, string str2)
{
    return str1.ToUpper() == str2.ToUpper();
}
