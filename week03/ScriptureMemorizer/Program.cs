

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference
        Reference reference = new Reference("Genesis", 11, 3, 4);


        // Create a scripture object with its reference and text
        Scripture scripture = new Scripture(
            reference,
            "They said to each other, Come, let’s make bricks and bake them thoroughly. They used brick instead of stone, and tar for mortar. Then they said, Come, let us build ourselves a city, with a tower that reaches to the heavens, so that we may make a name for ourselves; otherwise we will be scattered over the face of the whole earth."
        );


        // Continue until all scripture words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            // Display the current scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            //ENHANCEMENT: Display the number of visible words remaining 
            Console.WriteLine($"Words remaining: {scripture.GetVisibleWordCount()}");

            // Ask the user to continue or quit
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();


            // Exit the program if the user types quit
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }


            // Hide three random words
            scripture.HideRandomWords(3);
        }


        // Display the final scripture when all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}