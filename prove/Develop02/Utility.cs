using System;
using System.Collections.Generic;

public static class Utility
{
    private static List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What is your biggest goal?",
        "Describe a happy moment in your life.",
        "What is your favorite hobby?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
