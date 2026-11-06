using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         EXTRA FEATURES:

         1. Added 8 different journal prompts.
         2. Automatically records the date and time.
         3. Allows users to save and load their journal.
         4. Shows a message when the journal is empty.
         
         These features make journaling easier and more convenient.
        */

        // Create objects
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        Console.WriteLine("==============================");
        Console.WriteLine("       MY JOURNAL APP");
        Console.WriteLine("==============================");

        // Keep showing the menu until the user exits
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Exit");

            Console.Write("\nWhat would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Get a random question
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("\n" + prompt);

                // Get the user's answer
                Console.Write("> ");
                string response = Console.ReadLine();

                // Get today's date and time
                string date = DateTime.Now.ToString();

                // Create a new journal entry
                Entry entry = new Entry();

                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;

                // Add the entry to the journal
                journal.AddEntry(entry);

                Console.WriteLine("\nYour entry has been added!");
            }
            else if (choice == "2")
            {
                // Display all entries
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save the journal
                Console.Write("\nEnter the filename: ");
                string filename = Console.ReadLine();

                try
                {
                    journal.SaveToFile(filename);
                }
                catch
                {
                    Console.WriteLine("Something went wrong while saving.");
                }
            }
            else if (choice == "4")
            {
                // Load the journal
                Console.Write("\nEnter the filename: ");
                string filename = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(filename);
                }
                catch
                {
                    Console.WriteLine("Something went wrong while loading.");
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nThank you for using My Journal!");
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
            }
        }
    }
}
