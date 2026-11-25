using System;

// Main class where program execution begins.
class Program
{
    // Main method is the entry point of the program.
    static void Main(string[] args)
    {

        // CREATIVITY ENHANCEMENT:
        // I added an activity tracking feature that keeps count of how many
        // Breathing, Reflection, and Listing activities the user completes.
        // When the user quits the program, a session summary displays the
        // number of times each activity was completed and the total activities.
        // This helps users monitor their mindfulness practice during each session.


        // Stores the user's menu selection.
        string choice = "";

        // Initial Counters
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        // Keep displaying the menu until the user chooses 4.
        while (choice != "4")
        {
            // Clear the previous activity's output.
            Console.Clear();

            // Display the available activities.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            // Ask the user to select an activity.
            Console.Write("Select a choice from the menu: ");

            // Read and store the user's choice.
            choice = Console.ReadLine();

            // Start the breathing activity if the user selects 1.
            if (choice == "1")
            {

                BreathingActivity breathingActivity = new BreathingActivity();
                Console.WriteLine();
                breathingActivity.Run();
                breathingCount++;
            }

            // Start the reflecting activity if the user selects 2.
            else if (choice == "2")
            {
                Console.WriteLine();

                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingCount++;
            }

            // Start the listing activity if the user selects 3.
            else if (choice == "3")
            {
                Console.WriteLine();

                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingCount++;
            }

            // Exit the program if the user selects 4.
            else if (choice == "4")
            {
                int totalActivities = breathingCount + reflectingCount + listingCount;

                Console.WriteLine();
                Console.WriteLine("SESSION SUMMARY");
                Console.WriteLine("----------------------");
                Console.WriteLine($"Breathing activities: {breathingCount}");
                Console.WriteLine($"Reflection activities: {reflectingCount}");
                Console.WriteLine($"Listing activities: {listingCount}");
                Console.WriteLine($"Total activities completed: {totalActivities}");
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program.");
            }


            // Handle any choice that is not between 1 and 4.
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 4.");
            }

            // Pause before returning to the menu.
            // Do not pause when the user chooses to quit.
            if (choice != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}