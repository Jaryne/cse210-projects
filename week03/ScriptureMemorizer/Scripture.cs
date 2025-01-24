using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text to words then store as Word objects
        string[] splitWords = text.Split(' '); // look this up
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display(bool showHint = false)
    {
        // Console.Clear(); -- got an exception
        try
        {
            Console.Clear();
        }
        catch (Exception)
        {
            // If clear still fails, ignore.
        }

        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            if (showHint && word.Hidden())
            {
            Console.Write(word.GetHint() + " ");    
            }

            else
            {
            Console.Write(word.GetText() + " ");
            }
        }

        Console.WriteLine();
    }

    public void HideRandomWords(int count, bool hideOnlyVisible = true)
    {
        Random random = new Random();

        for (int i=0; i < count; i++) // for every number starting at 0, keep going as long as the number is less than 'count', and increase number by 1 each time.**
        {
            List<Word> wordsToHide = new List<Word>();

            // Collect only words that aren't hidden
            foreach (Word word in _words)
            {
                if (!hideOnlyVisible || !word.Hidden())
                {
                    wordsToHide.Add(word);
                }
            }

            if (wordsToHide.Count == 0)
            {
                break;
            }

            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();

        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }
}