using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playagain = true;

        while (playagain)
        {
            int magicnumber = random.Next(1, 101);
            int guesscount = 0;
            int userguess = 0;

            Console.WriteLine(" Guess my magic number, it's between 1 and 100.");

            while (userguess != magicnumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                userguess = int.Parse(input);
                guesscount++;
                if (userguess < magicnumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userguess > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesscount} guesses.");
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playagain = false;
            }
        }
        Console.WriteLine("Thank you for playing!");
    }
}