using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string user = Console.ReadLine();
        int userInput = int.Parse(user);

        string letter = "";


        if(userInput >= 90)

            
        { 
            letter = "A";
        }
              
        
        
        else if (userInput >= 80)
        {
            letter = "B";
        }

        else if (userInput >= 70)
        {
            letter = "C";
        }

        else if (userInput >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
       

        int number = 10;
        string sign = "";
        string plusSign = "+";
        string minusSign = "-";
        int signCalculation = 0;

        signCalculation = userInput % number ;

        if(signCalculation < 3)
        {
            sign = minusSign;
            if (userInput < 93)
            {
                Console.WriteLine($"{letter}{sign}");

            }
            
        }
        
        else
        {
            Console.WriteLine(letter);
        }
        

        if (userInput >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");

        }
        else
        {
            Console.WriteLine("You can do better next time");
        }
    
    }

}