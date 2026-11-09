using System;
using System.Collections.Generic;

// The PromptGenerator class manages the journal questions.
public class PromptGenerator
{
    // Creates a list to store journal prompts.
    public List<string> _prompts = new List<string>();

    // Automatically adds prompts to the list.
    public PromptGenerator()
    {
        // Adds journal questions to the prompt list.
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

    // Returns a randomly selected journal prompt.
    public string GetRandomPrompt()
    {
        // Creates a random number generator.
        Random random = new Random();

        // Generates a random position in the prompt list.
        int index = random.Next(_prompts.Count);

        // Returns the prompt at that index.
        return _prompts[index];
    }
}