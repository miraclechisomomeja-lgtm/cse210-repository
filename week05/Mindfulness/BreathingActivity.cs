

using System;

// BreathingActivity inherits the common features from Activity.
public class BreathingActivity : Activity
{
    // Constructor supplies the breathing activity's name and description
    // to the parent class.
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
        0)
    {
    }

    // Controls the entire breathing activity.
    public void Run()
    {
        // Display the welcome message and ask for the session duration.
        DisplayStartingMessage();

        // Prepare the user before beginning.
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        // Calculate when the breathing activity should end.
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Continue the breathing exercise until the time expires.
        while (DateTime.Now < endTime)
        {
            // Guide the user to breathe in.
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            // Guide the user to breathe out.
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        // Display the completion message.
        DisplayEndingMessage();
    }
}




