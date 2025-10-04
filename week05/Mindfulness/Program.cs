using System;
//  Program Enhancement:
// I enhanced my program, by adding a certification message in the activity class and had effect to each of the activity that the user completed. 
// This certification contains, the activity and the duration they set to engage with each activity.
class Program
{
    static void Main(string[] args)

    {
            Console.WriteLine("Welcome to your Mindfulness Program");
            Console.WriteLine();

        while (true)
        {


            Console.WriteLine("Menu Options:");

            Console.Write("1.Breathing Activity\n2.Reflecting Activity\n3.Listing Activity\n4.quit\nPlease select an option from 1-4 ");
            string choice = Console.ReadLine();
            if (choice != "4")
            {

                if (choice == "1")
                {
                    BreathingActivity breath1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by prompting you to breath in and out slowly. Are you ready?");
                    breath1.DisplayStartingMessage();
                    Console.Clear();
                    breath1.Run();
                    breath1.DisplayEndingingMessage();
                    breath1.Certification();
                    Thread.Sleep(2000);
                    Console.WriteLine();

                }
                else if (choice == "2")
                {
                    ReflectingActivity ref1 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. How can you be better in every aspect of your life?");
                    ref1.DisplayStartingMessage();
                    Console.Clear();
                    ref1.Run();
                    ref1.DisplayEndingingMessage();
                    ref1.Certification();
                    Console.WriteLine();
                }

                else if (choice == "3")
                {
                    ListingActivity list1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many as you can in certain areas", 3);
                    list1.DisplayStartingMessage();
                    Console.Clear();
                    list1.Run();
                    list1.DisplayEndingingMessage();
                    list1.Certification();
                    Console.WriteLine();

                }

            }
            else
            {
                break;
            }
        }













    }


}