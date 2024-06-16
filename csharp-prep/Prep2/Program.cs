using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent_grade = int.Parse(answer);
        string lettergrade = "";
        string signgrade = "";
        if (percent_grade >= 90)
        {
            lettergrade = "A";
        }
        else if (percent_grade >= 80)
        {
            lettergrade = "B";
        }
        else if (percent_grade >= 70)
        {
            lettergrade = "C";
        }
        else if (percent_grade >= 60)
        {
            lettergrade = "D";
        }
        else {
            lettergrade = "F";
        }

        int lastdigit = percent_grade % 10;
        if (lettergrade == "A")
        {
            if (lastdigit < 3)
            {
                signgrade = "-";
            }
        }
        else if (lettergrade != "F")
        {
            if (lastdigit >= 7)
            {
                signgrade = "+";
            }
            else if (lastdigit < 3)
            {
                signgrade = "-";
            }
        }

        Console.WriteLine($"Your grade is {lettergrade}{signgrade}.");

        if (percent_grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else {
            Console.WriteLine("You did not pass the course. Better luck next time!");
        }

    }
}