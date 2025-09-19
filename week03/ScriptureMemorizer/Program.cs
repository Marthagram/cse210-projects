using System;
using System.Collections.Generic;

// I enhanced the Scripture Memorizer program by adding multiple scriptures 
// and allowing the program to randomly select one for the user to memorize.

public class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference refer1 = new Reference("John", 3, 16);
        Reference refer2 = new Reference("Proverbs", 3, 5);
        Reference refer3 = new Reference("Doctrine and Covenants", 36, 6);
        Reference refer4 = new Reference("1 Nephi", 3, 7);
        Reference refer5 = new Reference("Mosiah", 2, 17);
        
        
        Scripture script1 = new Scripture (refer1, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");
        Scripture script2 = new Scripture (refer2, "Trust in the Lord with all thine heart and lean not unto thine own understanding");
        Scripture script3 = new Scripture (refer3, "Look unto me in every thought doubt not fear not");
        Scripture script4 = new Scripture (refer4, "I will go and do the things which the Lord hath commanded");
        Scripture script5 = new Scripture (refer5, "When ye are in the service of your fellow beings ye are only in the service of your God");

        scriptures.Add(script1);
        scriptures.Add(script2);
        scriptures.Add(script3);
        scriptures.Add(script4);
        scriptures.Add(script5);


        Random random = new Random();
        Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

        
        while (!randomScripture.IsCompletelyHidden())
        {


            Console.Clear();
            Console.WriteLine("Welcome to your Scripture Memorizer Program!");

            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to stop");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            randomScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine("Great job! You have completed memorizing the scripture.");
        Console.WriteLine(randomScripture.GetDisplayText());
    }
}


