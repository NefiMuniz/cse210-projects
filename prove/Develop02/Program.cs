using System;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save and Exit");
            Console.WriteLine("4. Exit without saving");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveAndExit();
                    exit = true;
                    break;
                case "4":
                    ExitWithoutSaving();
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddEntry()
    {
        string prompt = Utility.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);

        bool confirmed = false;
        while (!confirmed)
        {
            Console.WriteLine($"\nReview your entry:\n{entry}\n");
            Console.WriteLine("1. Confirm");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Cancel");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry(entry);
                    confirmed = true;
                    break;
                case "2":
                    Console.Write("Edit your response: ");
                    entry.EntryText = Console.ReadLine();
                    break;
                case "3":
                    confirmed = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayEntries()
    {
        Console.WriteLine("1. Display current session entries");
        Console.WriteLine("2. Display from journal file");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                if (journal.HasEntries())
                {
                    journal.DisplayEntries();
                }
                else
                {
                    Console.Write("No entries in the current session, press any key to return to the menu...")
                    Console.ReadKey();
                }
                break;
            case "2":
                Console.Write("Enter date (dd/MM/yyyy), month (MM/yyyy), year (yyyy), or 'all': ");
                string dateChoice = Console.ReadLine();
                journal.LoadFromFile("journal.csv", dateChoice);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void SaveAndExit()
    {
        journal.SaveToFile("journal.csv");
        Console.WriteLine("Journal saved successfully. Press any key to exit.");
        Console.ReadKey();
    }

    static void ExitWithoutSaving()
    {
        Console.WriteLine("Are you sure you want to exit without saving? All entries will be lost. Type 'confirm' to exit.");
        string confirm = Console.ReadLine();
        if (confirm.ToLower() == "confirm")
        {
            Console.WriteLine("Exiting without saving. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
