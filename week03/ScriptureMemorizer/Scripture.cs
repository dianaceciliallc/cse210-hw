using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture( Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] words = text.Split(' ');

        foreach( string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        for( int i = 0; i < numberToHide; i++ )
        {
            int randomIndex = random.Next(_words.Count);

            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText(bool useHint)
    {
        string scripture = "";

        foreach( Word word in _words)
        {
            if ( useHint )
            {
                scripture += word.GetHint() + " ";
            }
            else
            {
                scripture += word.GetDisplayText() + " ";
            }
        }
        return $"{_reference.GetDisplayText()} {scripture}";
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}