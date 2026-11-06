using System;

public class Entry
{
    // Member variables
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor
    public Entry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    // Display the journal entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}
