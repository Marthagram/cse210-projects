using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Comment comt1 = new Comment("Joy", "This is Wonderful");
        Comment comt2 = new Comment("Nancy", "Thanks for the update");
        Comment comt3 = new Comment("StellaMaris", "You are doing well");
        Comment comt4 = new Comment("Grey Anthony", "What are the ingredients for Pancakes?");
        Comment comt5 = new Comment("Loveth Ruth", "I practiced cake making with the help of this tutorial yesterday and it came out nice. Thank you Coach Martha!");
        Comment comt6 = new Comment("Landon Kirby", "When is the next Video dropping for this lesson");
        Comment comt7 = new Comment("Hope Mickaelson", "How do I read from a file, Sir?");
        Comment comt8 = new Comment("Josie Caro", "Is there any other programming language apart from HTML for writing and arranging text and other data on a webpage?");
        Comment comt9 = new Comment("Milton Greasley", "I really want to improve in speaking English");
        Comment comt10 = new Comment("Lizzie Caro", "Where can I get good books to read and improve my speech vocalbury");
        Comment comt11 = new Comment("Paul Joe", "Hmmm, thank you for this lesson");
        Comment comt12 = new Comment("Mavins Epod", "please where can I get original beads");
        Comment comt13 = new Comment("Ivon Vicky", "Hello, am new here");
        Comment comt14 = new Comment("Rowland Accra", "Ivon Vicky, You are welcome to the group. So you also love making beads?");
        Comment comt15 = new Comment("Jessie Prince", "I have a soft spot for Creative Arts!");
    


        Video vid1 = new Video("Cake Tutorial", "Martha", 45, comt1, comt2, comt3, comt4, comt5);
        Video vid2 = new Video("Coding Tutorial", "Justice", 150, comt6, comt7, comt8);
        Video vid3 = new Video("English Speaking", "Gabriella", 200, comt9, comt10, comt11);
        Video vid4 = new Video("Bead Making Tutorial", "Jordan", 180, comt12, comt13, comt14, comt15);

        
        List<Video> _videos = new List<Video>();
        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);
        _videos.Add(vid4);
        foreach (Video vid in _videos)
        {
            Console.WriteLine($"___________________________________________________________________\n");
            Console.WriteLine($"{vid._title}, by {vid._author}, Video Length: {vid._videoLength} seconds, Number of Comments: {vid.NumberOfComments()}\n");
            foreach (Comment comt in vid._comments)
            {
                Console.WriteLine($"{comt._commentorName}: {comt._comment} \n");
            }
    
        }
    }


    
}