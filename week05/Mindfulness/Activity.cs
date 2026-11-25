using System;
using System.Collections.Generic;
using System.Threading;

// Parent class containing features shared by all activities.
public class Activity
{
    // Private attributes that store the activity's information.
    private string _name;
    private string _description;
    private int _duration;

    // Constructor initializes the common activity information.
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Displays the activity's welcome message and asks for its duration.
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
    }


    // Displays a message when the activity is completed.
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

        // Shows a spinner before finishing.
        ShowSpinner(3);
    }

    // Displays a rotating animation for the specified number of seconds.
    public void ShowSpinner(int seconds)
    {
        // Characters used to create the spinning animation.
        List<string> animationStrings = new List<string>();

        animationStrings.Add(".");
        animationStrings.Add("..");
        animationStrings.Add("...");
        animationStrings.Add("....");

        // Calculate when the animation should stop.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        // Continue displaying the animation until time runs out.
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);

            Thread.Sleep(250);

            // Erase the previous character.
            Console.Write("\r  \r");

            // Move to the next animation character.
            i++;

            // Return to the beginning when the list ends.
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    // Displays a countdown, one number at a time.
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            // Erase the previous number.
            Console.Write("\b \b");
        }
    }

    // Allows child classes to access the activity duration.
    protected int GetDuration()
    {
        return _duration;
    }
}


