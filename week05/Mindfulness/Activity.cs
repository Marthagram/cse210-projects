public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private string _person;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }
    public int GetDuration()
    {
        return _duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to your {_name}\n{_description}");
        Console.WriteLine();


        Console.WriteLine();
        Console.WriteLine($"How long do you like to engage with {_name} (in seconds)");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Enter your name: ");
        _person = Console.ReadLine();
    }

    public void DisplayEndingingMessage()
    {
        Console.WriteLine($"Weldone!\n\nYou completed {_name} in {_duration} seconds");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\"); 

        for( int i = seconds; i > 0; i--)
        {
            foreach( string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        
        
        for( int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    
    

    public void Certification()
    {
        Console.WriteLine("CERTIFICATION");
        Console.WriteLine();
        Console.WriteLine($"This is to certify that {_person} has completed the {_name}\nand has been awarded with the certificate of\nparticipation.\nOnce again, Congratulations {_person}");
    }


}