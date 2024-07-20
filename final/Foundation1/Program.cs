using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the videos
        Video video1 = new Video("How to Cook Pizza", "Nefi Muniz", 480);
        Video video2 = new Video("Introduction to C#", "Alex Christensen", 3600);
        Video video3 = new Video("How to deploy your program", "John Dev", 1200);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Thanks for the tips!"));
        video1.AddComment(new Comment("Charlie", "Delicious recipe!"));

        video2.AddComment(new Comment("Dave", "Very informative."));
        video2.AddComment(new Comment("Eve", "Helped me a lot, thanks!"));
        video2.AddComment(new Comment("Frank", "I learned so much!"));

        video3.AddComment(new Comment("Grace", "Usefull information."));
        video3.AddComment(new Comment("Hank", "Amazing."));
        video3.AddComment(new Comment("Ivy", "Thank you, helped a lot."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
