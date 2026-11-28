using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration +
                          " seconds of the " + _name + ".");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}