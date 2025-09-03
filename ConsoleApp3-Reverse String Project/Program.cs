namespace ConsoleApp3_Reverse_String_Project;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome. Please input some text: ");
        string userInput = Console.ReadLine();
        char[] charArray = userInput.ToCharArray();
        Array.Reverse(charArray);
        string userInputReversed = new string(charArray);
        Console.WriteLine(userInputReversed);
    }
}