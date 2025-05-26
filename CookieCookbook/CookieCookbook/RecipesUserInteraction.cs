
public class RecipesUserInteraction
{
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();  
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
}