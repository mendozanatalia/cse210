public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture (Reference reference, string text)
    {
        // Stablish the variable to work with
        _reference = reference;
        // Create a new list to store the words
        _words = new List<Word>();
        // Divide the text in words
        string[] words = text.Split(' ');
        // Iterates through each word and store them in the words list
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random r = new Random();
        // Inicializate a counter for the hidden words
        int h = 0;
        
        // First we check if there are words to hide
        if (_words.All(word => word.IsHidden()))
        {
            return;
        }

        while (h < numberToHide)
        {
            int index = r.Next(_words.Count);
            // Only hide the word if it's not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                // A counter to check how many words we've hidden.
                h++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayedText = _reference.GetDisplayText() + " ... ";
        foreach (Word word in _words)
        {
            displayedText += word.GetDisplayText() + " ";
        }
        return displayedText;
    }

    public bool IsCompletelyHidden()
    {
        // foreach (Word word in _words)
        // {
        //     // If word is NOT hidden
        //     if (!word.IsHidden())
        //     {
        //         return false;
        //     }
        // }
        // return true;

        // OPTIMIZING: I used a lambda expression (doing some research)
        return _words.All(word => word.IsHidden());
    }
}