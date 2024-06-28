using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        
        // List scriptures and allow user to choose one
        Console.WriteLine("Choose a scripture:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText().Split('\n')[0]}");
        }

        int choice;
        while (true)
        {
            Console.Write("Enter the number of the scripture you want to choose: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= scriptures.Count)
            {
                break;
            }
            Console.WriteLine("Invalid choice, please try again.");
        }

        Scripture selectedScripture = scriptures[choice - 1];

        // Main loop
        while (true)
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            // Prompt the user
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Check if the user wants to quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random number of words between 2 and 4
            selectedScripture.HideRandomWords();

            // Check if all words are hidden
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }

    // Method to load scriptures from a file
    static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int id = int.Parse(parts[0]);
            string referenceText = parts[1];
            string text = parts[2];

            string[] referenceParts = referenceText.Split(new char[] { ' ', ':' });
            string book = referenceParts[0];
            int chapter = int.Parse(referenceParts[1]);
            string[] verseParts = referenceParts[2].Split('-');

            Reference reference;
            if (verseParts.Length == 1)
            {
                reference = new Reference(book, chapter, int.Parse(verseParts[0]));
            }
            else
            {
                reference = new Reference(book, chapter, int.Parse(verseParts[0]), int.Parse(verseParts[1]));
            }

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}
