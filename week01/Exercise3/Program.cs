using System;

class Program
{
    static void Main(string[] args)
    {   
        
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        

        Console.Write("What is the guess number? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        
        int count = 0;
        while (magicNumber != guessNumber)
      
        {
            count += 1;
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Guess higher");

                Console.Write("What is the guess number? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                

            }

            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Guess lower");
                  
                Console.Write("What is the guess number? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                

            }

        if (magicNumber == guessNumber)
        {
            Console.WriteLine($"You guessed it !, it took you {count} guesses");
            
        }
              
        }
           

    }
}