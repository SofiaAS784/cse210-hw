public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string w in words)
        {
            Word Word = new Word(w);
            _words.Add(Word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        while (numberToHide > 0)
        {
            if (numberToHide > _words.Count)
            {
                numberToHide = _words.Count;
            }
            int i = random.Next(_words.Count);
            Word hiddenWord = _words[i];
            if (hiddenWord.IsHidden() == false)
            {
                hiddenWord.Hide();
                numberToHide--;
            }
            else if (hiddenWord.IsHidden() == false)
            {
                hiddenWord.Show();
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}: {string.Join(" ", wordTexts)}";
    }
    public bool IsCompletelyHidden()
    {
        int hiddenNumber = 0;
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == true)
            {
                hiddenNumber++;
            }
        }
        if (hiddenNumber == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}