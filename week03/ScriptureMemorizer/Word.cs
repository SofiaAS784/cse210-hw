public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _text = new string('_', _text.Length);
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
        return _text;
    }
}