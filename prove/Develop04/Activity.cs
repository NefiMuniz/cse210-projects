using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private static ActivityLog _activityLog = new ActivityLog();
    private static string logFilePath = "activityLog.txt";

    // List of motivational quotes
    private static readonly List<string> quotes = new List<string>
    {
        "Keep pushing forward.",
        "You are stronger than you think.",
        "Believe in yourself.",
        "Every step counts."
    };

    // Static constructor to load the log file when the class is first accessed
    static Activity()
    {
        _activityLog.LoadLog(logFilePath);
    }

    // Constructor to initialize the name and description of the activity
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to start the activity
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    // Method to end the activity
    public void EndActivity()
    {
        _activityLog.AddLog(_name, _duration);
        _activityLog.SaveLog(logFilePath);
        
        ShowSpinner(2);
        Console.Clear();
        Console.WriteLine("Well done! You've completed the activity.");
        ShowSpinner(4);
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds");
        ShowSpinner(4);
        ShowMotivationalQuote();
        ShowSpinner(5);
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    // Method to display a random motivational quote
    private void ShowMotivationalQuote()
    {
        Random random = new Random();
        string quote = quotes[random.Next(quotes.Count)];
        Console.WriteLine($"Motivational Quote: {quote}");
    }

    // Method to get the duration of the activity
    protected int GetDuration()
    {
        return _duration;
    }

    // Method to show a spinner animation for a given number of seconds
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        // Console.WriteLine();
    }

    // Method to show a countdown from the given number of seconds
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    // Abstract method to be implemented by derived classes to perform the specific activity
    public abstract void PerformActivity();
}
