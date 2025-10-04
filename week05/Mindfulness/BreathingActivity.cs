public class BreathingActivity:Activity
{

    public BreathingActivity(string name, string description):base(name, description)
    {

    }

    private List<string> Breathing()
    {

        List<string> breathes = new  List<string>();
        breathes.Add("Breath in ... ");
        breathes.Add("Now, Breath out ... ");
        return breathes;

    }



    public void Run()
    {   
        int i = 0;
        string b;
        Console.WriteLine("Get Ready.."); 
        base.ShowSpinner(1);
        Thread.Sleep(1000);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

      
        while( DateTime.Now < futureTime)
        {  
            b = Breathing()[i];
            Console.WriteLine(b);
            base.ShowCountDown(5);
            Thread.Sleep(1000);
            Console.WriteLine();

            i++;
            if (i >= Breathing().Count)
            {
                i = 0;
            }
        }
        base.ShowSpinner(1);
       
        //  ADVICE TO ME:
        // If a method returns a value and you need to use that value multiple times, it's good practice to store it in a variable. This approach has several benefits:

        // 1. Efficiency: You avoid calling the method multiple times, which can save processing time and resources.
        // 2. Readability: Your code becomes more readable, as you don't have to repeat the method call.
        // 3. Maintainability: If the method's behavior changes, you only need to update the code in one place (where you store the value).

        // so my advice is to store the result of GetDuration() and Breathing() in a variable if you plan to use it multiple times within the Run method.
                


    }
        

       
    
}