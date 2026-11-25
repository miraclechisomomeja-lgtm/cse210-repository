


using System;
using System.Collections.Generic;

// ListingActivity inherits common features from Activity.
public class ListingActivity : Activity
{
    // Keeps track of the number of responses entered.
    private int _count;

    // Stores the listing prompts.
    private List<string> _prompts;

    // Constructor initializes the activity and its attributes.
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
        // Start the response count at zero.
        _count = 0;

        // Create an empty list for the prompts.
        _prompts = new List<string>();

        // Add listing prompts.
        _prompts.Add("What are some of your favorite memories?");
        _prompts.Add("What are some things you are grateful for today?");
        _prompts.Add("Who has had a positive influence on your life?");
        _prompts.Add("What are some goals you are working toward right now?");
        _prompts.Add("What is something you have accomplished that you are proud of?");
        _prompts.Add("Who are people that have helped you this week?");
        _prompts.Add("When have you felt peace this month?");
        _prompts.Add("What are some talents or skills you have developed?");
        _prompts.Add("What is a challenge you have overcome recently?");
        _prompts.Add("Who are people that you can turn to when you need support?");
        _prompts.Add("What blessings have you noticed in your life lately?");
        _prompts.Add("When have you felt close to God this month?");
        _prompts.Add("What are some ways you have grown in the past year?");
        _prompts.Add("What is something kind that someone did for you recently?");
        _prompts.Add("What are some of your family's traditions that you value?");
    }

    // Selects and returns a random listing prompt.
    public string GetRandomPrompt()
    {
        Random random = new Random();

        // Generate a random index within the prompt list.
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    // Collects the user's responses and returns them as a list.
    public List<string> GetListFromUser()
    {
        // Create an empty list to store the responses.
        List<string> responses = new List<string>();

        // Calculate when the listing session should end.
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Continue collecting responses while time remains.
        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");

            // Read the user's response.
            string response = Console.ReadLine();

            // Only add responses that are not empty.
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);

                // Increase the number of responses.
                _count++;
            }
        }

        // Return the collected responses.
        return responses;
    }

    // Controls the entire listing activity.
    public void Run()
    {
        // Display the welcome message and ask for the duration.
        DisplayStartingMessage();

        // Prepare the user.
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();

        // Display a random listing prompt.
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        // Adding the Listing Activity Countdown
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start Listing!");

        Console.WriteLine();

        // Collect the user's responses.
        GetListFromUser();

        // Display the total number of responses.
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        // Display the completion message.
        DisplayEndingMessage();
    }
}





