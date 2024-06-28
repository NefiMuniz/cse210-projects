using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialize the scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a specified number of random words
public void HideRandomWords()
{
    Random random = new Random();
    int numberToHide = random.Next(2, 5); // Random number between 2 and 4
    int hiddenCount = 0;

    while (hiddenCount < numberToHide)
    {
        int index = random.Next(_words.Count);
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
        }

        // Break if all words are already hidden
        if (IsCompletelyHidden())
        {
            break;
        }
    }
}


    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + "\n" + scriptureText.Trim();
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
