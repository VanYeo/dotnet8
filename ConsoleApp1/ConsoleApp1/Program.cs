Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

// convert userinput to upper using ? if userInput isn't null
var userInput = Console.ReadLine()?.ToUpper();
List <string> ToDoList = new List<string>();

while (userInput != "S" && userInput != "A" && userInput != "R" && userInput != "E")
{
    Console.WriteLine("Invalid input. Please enter S, A, R, or E.");
    userInput = Console.ReadLine()?.ToUpper();
}
while (userInput != "E")
{
    Console.WriteLine("What do you want to do?");
    userInput = Console.ReadLine()?.ToUpper();
    if (userInput == "A")
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine();
        while (ToDoList.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
            Console.WriteLine("Enter the TODO description:");
            description = Console.ReadLine();
        }
        ToDoList.Add(description);
        Console.WriteLine("TODO successfully added: " + description);
        continue;
    }
    if (userInput == "S")
    {
        DisplayToDoList(ToDoList);
        continue;
    }
    if (userInput == "R")
    {
        Console.WriteLine("Select the index of the TODO you want to remove"); 
        DisplayToDoList(ToDoList);
        var index = Console.ReadLine();
        if (index != null && int.TryParse(index, out int indexInt) && indexInt > 0 && indexInt <= ToDoList.Count)
        {
            string removedTodo = ToDoList[indexInt - 1];
            ToDoList.RemoveAt(indexInt - 1);
            Console.WriteLine("TODO successfully removed: " + removedTodo);
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a valid number.");
        }
    }
}
Console.ReadKey();

void DisplayToDoList(List<string> ToDoList)
{
    Console.WriteLine("TODOs:");
    for (int i = 0; i < ToDoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {ToDoList[i]}");
    };
}

// or using switch

while (userInput != "E")
{
    Console.WriteLine("What do you want to do?");
    userInput = Console.ReadLine()?.ToUpper();

    switch (userInput)
    {
        case "A":
            Console.WriteLine("Enter the TODO description:");
            var description = Console.ReadLine();
            while (ToDoList.Contains(description))
            {
                Console.WriteLine("The description must be unique.");
                Console.WriteLine("Enter the TODO description:");
                description = Console.ReadLine();
            }
            ToDoList.Add(description);
            Console.WriteLine("TODO successfully added: " + description);
            break;

        case "S":
            DisplayToDoList(ToDoList);
            break;

        case "R":
            Console.WriteLine("Select the index of the TODO you want to remove");
            DisplayToDoList(ToDoList);
            var index = Console.ReadLine();
            if (index != null && int.TryParse(index, out int indexInt) && indexInt > 0 && indexInt <= ToDoList.Count)
            {
                string removedTodo = ToDoList[indexInt - 1];
                ToDoList.RemoveAt(indexInt - 1);
                Console.WriteLine("TODO successfully removed: " + removedTodo);
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a valid number.");
            }
            break;

        case "E":
            // Exit the loop
            break;

        default:
            Console.WriteLine("Invalid input. Please enter S, A, R, or E.");
            break;
    }
}
Console.ReadKey();