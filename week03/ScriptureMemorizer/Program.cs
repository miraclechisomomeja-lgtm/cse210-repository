


using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine();


        // ENHANCEMENT 2: Allow users to select a scripture
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. Psalm 23:1");
        Console.WriteLine("2. Joshua 1:9");
        Console.WriteLine("3. Romans 8:28");
        Console.WriteLine("4. Choose a random scripture");

        Console.Write("Enter your choice (1-4): ");

        string choice = (Console.ReadLine() ?? "").Trim();


        // ENHANCEMENT 4: Randomly select a scripture
        if (choice == "4")
        {
            Random random = new Random();

            choice = random.Next(1, 4).ToString();

            Console.WriteLine($"Randomly selected option: {choice}");
        }


        // Assign the scripture reference and text
        Reference reference;
        string scriptureText;

        if (choice == "1")
        {
            reference = new Reference("Psalm", 23, 1);

            scriptureText =
                "The LORD is my shepherd; I shall not want.";
        }
        else if (choice == "2")
        {
            reference = new Reference("Joshua", 1, 9);

            scriptureText =
                "Be strong and of a good courage; be not afraid, neither be thou dismayed: for the LORD thy God is with thee whithersoever thou goest.";
        }
        else if (choice == "3")
        {
            reference = new Reference("Romans", 8, 28);

            scriptureText =
                "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.";
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
            return;
        }


        // Create the scripture object
        Scripture scripture = new Scripture(reference, scriptureText);


        // Continue until all scripture words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            // Display the current scripture
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());


            // ENHANCEMENT 1: Count and display visible words remaining
            Console.WriteLine(
                $"Words remaining: {scripture.GetVisibleWordCount()}"
            );


            // Display available commands
            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide 3 words.");
            Console.WriteLine("Type 'show' to reveal one hidden word.");
            Console.WriteLine("Type 'quit' to exit.");

            string input = (Console.ReadLine() ?? "").Trim().ToLower();


            // Exit the memorization session
            if (input == "quit")
            {
                break;
            }


            // ENHANCEMENT 3: Reveal one randomly hidden word
            else if (input == "show")
            {
                scripture.ShowRandomWord();
            }


            // ORIGINAL REQUIREMENT: Hide three random words
            else if (input == "")
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }


        // Display the final scripture when all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("All words have been hidden. Well done!");
        }


        // Display the closing message
        Console.WriteLine();
        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }
}