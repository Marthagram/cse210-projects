using System;

class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers = new List<int>();
        int userInput = -1;
        int sum = 0;
        float average = 0; 
        int maximum = 0;
        int count = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished ");
                
        
        while (userInput != 0)
        
        {   
            Console.Write("Enter number ");
            string user = Console.ReadLine();
            userInput = int.Parse(user);

            if (userInput != 0)

            {    

                

                numbers.Add(userInput);
                count += 1;
                 
            } 
        }
        foreach (int number in numbers)

            {

            sum += number;
    
            if (number > maximum)
            {
                maximum = number;

            }

            
            }
        average = (float)sum / count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {maximum}");

    }
}