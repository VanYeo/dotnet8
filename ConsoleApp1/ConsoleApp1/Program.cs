//var number = 0;

//while (number < 10)
//{
//    number = number + 1;
//    Console.WriteLine("Number is: " + number);
//}

//Console.WriteLine("The loop is finished");

int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
   var sum = 0;
   while (firstNumber <= lastNumber)
   {
        sum += firstNumber;
        firstNumber++;
   }
    return sum;
}

Console.WriteLine(CalculateSumOfNumbersBetween(5,8));