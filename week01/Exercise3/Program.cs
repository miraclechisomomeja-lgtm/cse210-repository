using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            int guestCount = 1;

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guestCount++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {guestCount} guesses.");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        while (playAgain == "yes");
        Console.WriteLine("Thank you for using our Guess My Number game!");


    }
}