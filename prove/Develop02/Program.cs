// My core was to save the journal into a csv file
using System;
using System.Collections.Generic;

public class Program
{
    private static Journal journal = new Journal();

    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display current session entries");
            Console.WriteLine("3. Display from journal");
            Console.WriteLine("4. Save and Exit");
            Console.WriteLine("5. Exit without saving");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    DisplayCurrentSessionEntries();
                    break;
                case "3":
                    DisplayFromJournal();
                    break;
                case "4":
                    SaveAndExit();
                    return;
                case "5":
                    ExitWithoutSaving();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void AddEntry()
    {
        // Generate a random prompt
        string prompt = Utility.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        // Create a new entry and display it for confirmation
        Entry entry = new Entry(prompt, response);
        Console.WriteLine("Your entry:");
        Console.WriteLine(entry.ToString());
        Console.Write("Confirm entry? (yes/edit/cancel): ");
        string confirmation = Console.ReadLine().ToLower();

        switch (confirmation)
        {
            case "yes":
                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
                break;
            case "edit":
                Console.Write("Your new response: ");
                response = Console.ReadLine();
                entry = new Entry(prompt, response);
                journal.AddEntry(entry);
                Console.WriteLine("Entry updated.");
                break;
            case "cancel":
                Console.WriteLine("Entry canceled.");
                break;
            default:
                Console.WriteLine("Invalid choice. Entry canceled.");
                break;
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    private static void DisplayCurrentSessionEntries()
    {
        var entries = journal.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries in the current session, press any key to return to the menu...");
            Console.ReadKey();
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    private static void DisplayFromJournal()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        DisplayCurrentSessionEntries();
    }

    private static void SaveAndExit()
    {
        Console.Write("Enter filename to save as: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully. Press any key to exit.");
        Console.ReadKey();
    }

    private static void ExitWithoutSaving()
    {
        Console.WriteLine("Exiting without saving. All entries will be lost.");
        Console.Write("Type 'confirm' to exit without saving: ");
        string confirmation = Console.ReadLine().ToLower();
        if (confirmation == "confirm")
        {
            Console.WriteLine("Exiting without saving. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
