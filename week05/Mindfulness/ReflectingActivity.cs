

using System;
using System.Collections.Generic;

// ReflectingActivity inherits common features from Activity.
public class ReflectingActivity : Activity
{
    // Stores the reflection prompts.
    private List<string> _prompts;

    // Stores the reflection questions.
    private List<string> _questions;

    // Constructor initializes the activity and its lists.
    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        0)
    {
        // Create empty lists for prompts and questions.
        _prompts = new List<string>();
        _questions = new List<string>();

        // Add reflection prompts.
        _prompts.Add("Think of a time when you forgave someone.");
        _prompts.Add("Think of a time when you overcame a fear.");
        _prompts.Add("Think of a time when you made someone smile.");
        _prompts.Add("Think of a time when you learned from a mistake.");
        _prompts.Add("Think of a time when you showed courage.");
        _prompts.Add("Think of a time when you were grateful for someone's help.");
        _prompts.Add("Think of a time when you kept a promise that was hard to keep.");
        _prompts.Add("Think of a time when you shared something you cared about.");
        _prompts.Add("Think of a time when you listened to someone who needed to be heard.");
        _prompts.Add("Think of a time when you chose to do the right thing when no one was watching.");
        _prompts.Add("Think of a time when you encouraged someone who wanted to give up.");
        _prompts.Add("Think of a time when you put someone else's needs before your own.");
        _prompts.Add("Think of a time when you reached out to someone who felt alone.");
        _prompts.Add("Think of a time when you stayed patient in a frustrating situation.");
        _prompts.Add("Think of a time when you taught someone something new.");

        // Add reflection questions.
        _questions.Add("What made you decide to act?");
        _questions.Add("Who else was affected by what you did?");
        _questions.Add("What was the hardest part of this experience?");
        _questions.Add("Was there anything that surprised you?");
        _questions.Add("How did other people react?");
        _questions.Add("What would you do differently if it happened again?");
        _questions.Add("What strengths did you draw on in that moment?");
        _questions.Add("How has this experience shaped the way you treat others?");
        _questions.Add("What advice would you give someone facing a similar situation?");
        _questions.Add("How did this experience change your perspective?");
        _questions.Add("What part of this experience are you most proud of?");
        _questions.Add("Who helped you or inspired you along the way?");
        _questions.Add("How did you feel before you took action?");
        _questions.Add("What values guided your choices?");
        _questions.Add("How can you apply what you learned to other areas of your life?");
    }

    // Selects and returns a random reflection prompt.
    public string GetRandomPrompt()
    {
        Random random = new Random();

        // Generate a random index within the prompt list.
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    // Selects and returns a random reflection question.
    public string GetRandomQuestion()
    {
        Random random = new Random();

        // Generate a random index within the question list.
        int index = random.Next(_questions.Count);

        return _questions[index];
    }

    // Displays a random reflection prompt to the user.
    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        // Wait for the user to think about the prompt.
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    // Displays random reflection questions during the session.
    public void DisplayQuestions()
    {
        // Calculate when the question session should end.
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            // Display a random question.
            Console.WriteLine(GetRandomQuestion());

            // Give the user time to reflect before the next question.
            ShowSpinner(5);

            Console.WriteLine();
        }
    }

    // Controls the entire reflecting activity.
    public void Run()
    {
        // Display the welcome message and ask for the duration.
        DisplayStartingMessage();

        // Prepare the user.
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        // Display a reflection prompt.
        DisplayPrompt();

        // Introduce the reflection questions.
        Console.WriteLine("Now ponder on each of the following questions...");
        ShowSpinner(5);

        Console.WriteLine();

        // Display random questions.
        DisplayQuestions();

        // Display the completion message.
        DisplayEndingMessage();
    }
}




