using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Introduction to C# Programming",
            "John Smith",
            600
        );

        video1.AddComment(new Comment("Alice", "Great introduction to C#!"));
        video1.AddComment(new Comment("Mark", "This tutorial is very helpful."));
        video1.AddComment(new Comment("Sarah", "I learned something new today."));

        // Create the second video
        Video video2 = new Video(
            "Top 5 Travel Destinations",
            "Travel With Mike",
            850
        );

        video2.AddComment(new Comment("Jessica", "These places look amazing!"));
        video2.AddComment(new Comment("Robert", "I would love to visit Japan."));
        video2.AddComment(new Comment("Emma", "Beautiful scenery!"));

        // Create the third video
        Video video3 = new Video(
            "Healthy Breakfast Ideas",
            "Healthy Living",
            720
        );

        video3.AddComment(new Comment("Sophia", "I will try these recipes."));
        video3.AddComment(new Comment("James", "Very useful breakfast ideas."));
        video3.AddComment(new Comment("Olivia", "The smoothie looks delicious!"));

        // Create the fourth video
        Video video4 = new Video(
            "How to Improve Your Productivity",
            "Success Academy",
            900
        );

        video4.AddComment(new Comment("Lucas", "Great productivity tips!"));
        video4.AddComment(new Comment("Mia", "I really needed this advice."));
        video4.AddComment(new Comment("Ethan", "Time management is important."));

        // Create a list of videos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Loop through the videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------");

            video.Display();

            Console.WriteLine();
        }
    }
}