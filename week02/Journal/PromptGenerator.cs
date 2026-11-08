
using System;
using System.Collections.Generic;

// The PromptGenerator class is responsible for  controlling the journal questions.
public class PromptGenerator
{
    // Here Creates a list that will store journal prompts.
    public List<string> _prompts = new List<string>();

    // This is a constructor that automatically adds prompts to the list.
    public PromptGenerator()
    {
        // Responsible for adding journal questions.
        _prompts.Add("What is one thing that made me smile today?");
        _prompts.Add("What challenge did I overcome today?");
        _prompts.Add("What did I learn about myself today?");
        _prompts.Add("Who made a positive difference in my life recently?");
        _prompts.Add("What is one thing I could have done better today?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("What small achievement am I proud of?");
        _prompts.Add("What motivates me when life becomes difficult?");
        _prompts.Add("What is one habit I want to develop?");
        _prompts.Add("What would make tomorrow a successful day?");
    }

    // Here is responsible for returning a random journal prompt.
    public string GetRandomPrompt()
    {
        // Creates a random number generator.
        Random random = new Random();

        // Generates a random position in the prompt list.
        int index = random.Next(_prompts.Count);

        // Returns the prompt at tht index.
        return _prompts[index];
    }
}

