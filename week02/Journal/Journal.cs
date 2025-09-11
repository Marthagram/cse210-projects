
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        Console.WriteLine("Your Recorded Entries So Far:");


        foreach (Entry ent in _entries)
        {
            ent.Display();
        }

    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving the File...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach(Entry E in _entries )
            outputFile.WriteLine($"{E._date}~~{E._promptText}~~{E._entryText}");
        }
        
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Reading from the File");

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry entryFromFile = new Entry();
            entryFromFile._date = parts[0];
            entryFromFile._promptText = parts[1];
            entryFromFile._entryText = parts[2];
            _entries.Add(entryFromFile);
          

            Console.WriteLine($"{entryFromFile._date} -  {entryFromFile._promptText} ");
            Console.WriteLine($">>>>> {entryFromFile._entryText}");



        }
    }



   
}