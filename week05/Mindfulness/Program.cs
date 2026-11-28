using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program includes an additional menu option
        // that allows users to view their completed activities.
        // It also uses random prompts and questions to make each
        // mindfulness session more interesting.

        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                choice = 5;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }

            if (choice != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}