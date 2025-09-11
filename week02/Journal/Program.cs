using System;
using System.IO;

// Welcome to Your Journal! (Your Self-Safe Space),I enhanced my code my adding the following features:
// 1. I wrote an else if statement to handle invalid inputs from the user.
// 2. I added a double condition to the while loop to allow the user to quit by either entering "5" or "quit".
// 3. I added a check to ensure that the user saves their entries before attempting to load them, preventing potential errors.
//4. I also added a check to ensure that the user provides a filename before saving entries, enhancing user experience and preventing errors.
class Program
{
    static void Main(string[] args)
    
    {

        PromptGenerator promptObject = new PromptGenerator();
        promptObject._prompts.Add("What is one doctrine or belief of the Church of Jesus Christ of Latter-day Saints that gives you a firm foundation and deep understanding of the Gospel, Religion and God?");
        promptObject._prompts.Add("If you are to speak to someone about the restored Gospel, what are the key words you feel will resonate with them without you having to talk too much?");
        promptObject._prompts.Add("Who is someone who can always make you laugh out loud?");
        promptObject._prompts.Add("What is something that you have learnt recently that you wish everybody knew?");
        promptObject._prompts.Add("What is the best thing that happened to you today?");
        promptObject._prompts.Add("What is something you've read that really inspire you?");
       

        Journal diary = new Journal();
        
        string userInput = "";
        string filename = "";

        while ((userInput != "5") && (userInput != "quit"))

        {
            
            Console.WriteLine("Welcome to Your Journal! (Your Self-Safe Space)");
            Console.WriteLine("Please, Choose from the Menu below(1-5)");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display Journal ");
            Console.WriteLine("3. Save Entry ");
            Console.WriteLine("4. Load Entry from Storage");
            Console.WriteLine("5. quit");
            Console.Write("Enter a number(1-5):");
            userInput = Console.ReadLine();

            
            if ((userInput != "5") || (userInput != "quit"))
            {
                if (userInput == "1")
                {
                    Entry entry = new Entry();
                    entry._date = "27|02|2025";
                    entry._promptText = promptObject.GetRandomPrompt();
                    Console.WriteLine($"{entry._promptText} ");
                    entry._entryText = Console.ReadLine();

                    diary.AddEntry(entry);
                }

                else if (userInput == "2")
                {
                    diary.DisplayAll();
                }

                else if (userInput == "3")
                {   

                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();

                    if (string.IsNullOrEmpty(filename))
                    {
                        Console.WriteLine(">>>>> Please provide a filename to save your entries. Thank you.");
                        continue;
                    }
                    else
                    
                    {
                       
                        diary.SaveToFile(filename);
                    }
                    

                }

                else if (userInput == "4")

                {

                    if (string.IsNullOrEmpty(filename))

                    {
                        Console.WriteLine(">>>>> Please save your entries first before loading. Thank you.");
                        continue;
                    }
                    
                    else
                    { 
                        diary.LoadFromFile(filename);
                    }
                    
                }
                    
                

                else if ((userInput != "1") && (userInput != "2") && (userInput != "3") && (userInput != "4") && (userInput != "quit")&&(userInput != "5"))
                {
                    Console.WriteLine(">>>>> Please Enter a Number from 1 - 5, Thank you.");
                }
            } 

        }     
       

    }

}