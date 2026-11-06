using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variables
    public List<string> _prompts;
    public Random _random;

    // Constructor
    public PromptGenerator()
    {
        _random = new Random();

        _prompts = new List<string>();

        _prompts.Add("What was the best part of your day?");
        _prompts.Add("Who made you happy today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What made you smile today?");
        _prompts.Add("What are you thankful for today?");
        _prompts.Add("What was the hardest part of your day?");
        _prompts.Add("What is one thing you want to improve tomorrow?");
        _prompts.Add("What is something you want to remember about today?");
    }

    // Choose a random prompt
    public string GetRandomPrompt()
    {
        int number = _random.Next(_prompts.Count);

        return _prompts[number];
    }
}
