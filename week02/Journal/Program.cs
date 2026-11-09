
// The Program class controls the Journal application.
class Program
{

    // The Main method is where program execution begins.
    static void Main(string[] args)
    {

        // ==========================================
        // PROGRAM ENHANCEMENTS
        // 1. Mood Tracker:
        // Allows users to record their emotions
        // when writing journal entries.
        //
        // 2. Time Tracker:
        // Automatically records the time each
        // journal entry is created.
        //
        // Both enhancements are displayed, saved
        // to the file, and restored when loaded.
        // ==========================================



        // Creates a Journal object.

        Journal journal = new Journal();


        // Creates a PromptGenerator object.

        PromptGenerator promptGenerator = new PromptGenerator();


        // Stores the user's menu selection.

        string option = "";


        // Repeats the menu until the user chooses to quit.

        while (option != "5")
        {


            // Displays the welcome message and menu.

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            // Collects the user's menu selection.

            Console.Write("Which Option would you like to choose? ");
            option = Console.ReadLine();

            // Creates a blank space

            Console.WriteLine();

            // Option 1: Write a new journal entry.

            if (option == "1")
            {

                // Gets a randomly selected journal prompt.

                string prompt = promptGenerator.GetRandomPrompt();


                // Displays the selected prompt.

                Console.WriteLine(prompt);


                // Collects the user's written response.

                Console.Write("> ");
                string response = Console.ReadLine();


                // Creates a blank space
                Console.WriteLine();

                // Asks the user to record their mood.

                Console.WriteLine("How are you feeling today?");
                string mood = Console.ReadLine();



                // Creates a new Entry object.
                Entry entry = new Entry();



                // Records the date of the entry.
                entry._date = DateTime.Now.ToShortDateString();



                // Records the time of the entry.

                entry._time = DateTime.Now.ToShortTimeString();


                // Stores the selected prompt.
                entry._promptText = prompt;


                // Stores the user's response.
                entry._entryText = response;


                // Stores the user's mood.
                entry._mood = mood;


                // Adds the completed entry to the journal.
                journal.AddEntry(entry);
            }


            // Option 2: Displays all journal entries.

            else if (option == "2")
            {
                journal.DisplayAll();
            }


            // Option 3: Loads previously saved entries.
            else if (option == "3")
            {

                // Asks for the saved filename.

                Console.Write("What is the filename? ");
                string file = Console.ReadLine();


                // Loads the journal entries.

                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully.");
            }


            // Option 4: Saves journal entries.

            else if (option == "4")

            {

                // Asks for the filename.

                Console.Write("What is the filename? ");
                string file = Console.ReadLine();


                // Saves all current journal entries.

                journal.SaveToFile(file);

                Console.WriteLine("Journal saved successfully.");
            }


            // Option 5: Exits the program.

            else if (option == "5")
            {
                Console.WriteLine(
                    "Thank you for using the journal program. Goodbye!"
                );
            }



            // Handles invalid menu selections.

            else
            {
                Console.WriteLine(
                    "Invalid choice. Please select a number from 1 to 5."
                );
            }



            //Adds a blank line before the menu appears

            Console.WriteLine();
        }


    }
}
