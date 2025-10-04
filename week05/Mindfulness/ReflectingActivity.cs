public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you went on a stroll looking at nature all around",
        "Think of a time when you really made a concrete decision and stood by it",
        "Think of a time when you when you helped someone in need",
        "Think of a time when you let God prevail in your challenges and humbly let His will be done",
        "Think of a time when you overcame a difficult obstacle",
        "Think of a time when you learned something new about yourself"
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was completed?",
        "What is the favorite thing about this experience",
        "What could you learn from this experience that applies to other situations?",
        "How did this experience shape you as a person?",
        "What would you do differently if faced with a similar situation?",
        "What is one thing you learned from this experience?",
        "How can you apply the lessons from this experience to your daily life?",
        "What strengths did you discover about yourself through this experience?",
        "What is one thing you would like to improve about yourself?",
        "In what ways did this experience challenge your beliefs or values?"
    };

    // inorder to add multiple prompts and questions to their respective lists, I added them directly within the list 
    // initialization. This way, each time I create an instance of ReflectingActivity, it will have a predefined set of 
    // prompts and questions to choose from. Maintianing the principles of encapsulation all the lists are private

    Random random = new Random();

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        
        Console.WriteLine("Get Ready.."); 
        base.ShowSpinner(1);
        DisplayPrompt();
        Console.WriteLine("You may begin in: ");
        base.ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
      
        while( DateTime.Now < futureTime)
        {  
        
            DisplayQuestions();
            base.ShowSpinner(3); 
        }
    }

    public string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayQuestions()
    {
       
        Console.WriteLine(GetRandomQuestion());
            
    }
    public void DisplayPrompt()
    {
    
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
}

    
        
    

