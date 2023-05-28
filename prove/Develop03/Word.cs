using System;

public class Word
{
    private string _word;
    private bool isHidden;

    public Word(string word)
    {
        _word = word;
    }
    public void Hide()
    {
        isHidden = true;
    }
    public string GetText()
    {
        if (isHidden)
        {
            int wordLength = _word.Length;
            string hiddenWord = "";

            while (wordLength > 0)
            {
                hiddenWord += "-";
                wordLength--;
            }
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
    public bool IsHidden()
    {
        return isHidden;
    }
}