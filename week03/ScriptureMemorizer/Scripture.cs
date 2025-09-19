public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        for (int i = 0; i < numberToHide && i < visibleWords.Count; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }





    


    public string GetDisplayText()
    {   
        // THIS APPROACH STILL WORKS BUT I DO NOT UNDERSTAND LINQ CODES YET
        // string displayText = _reference.GetDisplayText() + "\n";
        // displayText += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        // return displayText;


        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText +=  word.GetDisplayText() + " ";
        }
        return displayText;

    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
        
        
}