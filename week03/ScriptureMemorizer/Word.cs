using System;
using System.Data.SqlTypes;
using System.Security.AccessControl;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        Console.Write($"{_text}");
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if(_isHidden)
        {
            return new string(' ',_text.Length).Replace(" ","_");
        }

        return _text;
    }

    public string GetHint()
    {
        if(_isHidden)
        {
            string underscores = new string(' ',_text.Length -1).Replace(" ","_");

            return _text.Substring(0, 1) + underscores;
        }
        if ( _text.Length <= 1)
        {
            return "_";
        }

        return _text;
    }
}