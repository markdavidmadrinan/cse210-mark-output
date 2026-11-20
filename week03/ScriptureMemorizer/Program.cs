using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding and in all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, text);

        string answer = "";

        while (answer != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish:");

            answer = Console.ReadLine();

            if (answer != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}
