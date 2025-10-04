public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are the helpful people in your life?",
        "What are your personal strengths?",
        "When do you feel most at peace?",
        "What are you most grateful for today?",
        "What are some of your proudest accomplishments?",
        "Who in your life has inspired you?",
        "What activities bring you joy?",
        "What are some of your favorite memories?",
        "What qualities do you value most in a friend?",
        "What are your goals for the next year?"
    };

    public ListingActivity(string name, string description, int count) : base(name, description)
    {
        _count = count;
    
    }
    public void Run()
    {   
        int i = 0;
        Console.WriteLine("Get Ready.."); 
        base.ShowSpinner(1);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        base.ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            string response = Console.ReadLine();
            i++;
            if (DateTime.Now >= futureTime)
            {
                break;
            }
        }
        Console.WriteLine($"You listed {i} items!");
    
    

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        for (int i = 0; i < _count; i++)
        {   
            string response = Console.ReadLine();
            responses.Add(response);
        }
        return responses;
    }

}
        