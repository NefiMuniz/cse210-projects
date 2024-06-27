using System;
using System.Collections.Generic;

public static class Utility
{
    private static List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Did you serve someone today?",
        "Describe a happy moment in your day.",
        "How did you help someone today?",
        "Did you learn anything new today?",
        "What did you learn from the scriptures today?",
        "How did you feel while praying today?",
        "How did you overcome a difficult situation today?",
        "What made you smile today?",
        "What is one thing you would like to improve about today?",
        "How did you show kindness to others today?",
        "What new idea or concept did you encounter today?",
        "How did you connect with your family or friends today?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
