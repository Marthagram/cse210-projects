using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int number = SquareNumber(favNumber);
          DisplayResult(name, number);
       
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    { 
        Console.Write("What is your name ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    { 
        Console.Write("What is your favorite number ");
        string favNumber = Console.ReadLine();
        int favorite = int.Parse(favNumber);
        return favorite;
    }

    static int SquareNumber(int parameter)
    {
       int result = (parameter) * (parameter);
       return result;
    }

    static void DisplayResult(string displayName, int displayNumber)
    {
        Console.WriteLine($"{displayName}, the square of your favorite number is {displayNumber}");
    }

}