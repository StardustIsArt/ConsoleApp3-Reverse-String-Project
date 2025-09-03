namespace ConsoleApp3_Reverse_String_Project;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome. Please input some text: ");
        string userInput = Console.ReadLine();
        string reversedUserInput = "";
        if (userInput is null)
        {
            Console.WriteLine("You have not entered any text. Please try again.");
        }
        if (userInput is not null)
        {
            for (int i = userInput.Length -1; i >= 0; i--)
            {
                reversedUserInput += userInput[i];
            }
            Console.WriteLine($"The reversed version of your input is: {reversedUserInput}");
        }
        
        
        
        /* char[] charArray = userInput.ToCharArray();
        Array.Reverse(charArray);
        string userInputReversed = new string(charArray);
        Console.WriteLine(userInputReversed); */
    }
}