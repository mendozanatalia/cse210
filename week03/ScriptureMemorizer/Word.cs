public class Word
{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // I have to did a researh for this line: it creates a new string replacing each word's letter with "_".
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}