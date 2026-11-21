
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create four video objects
        Video video1 = new Video("Learning C# Basics", "Miracle", 600);

        Video video2 = new Video("Introduction to Web Development", "John", 720);

        Video video3 = new Video("Understanding Object-Oriented Programming", "Sarah", 900);

        Video video4 = new Video("Working with Git and GitHub", "David", 480);


        // Add comments to video 1
        video1.AddComment(new Comment("Chisom", "This is a great introduction to C#!"));
        video1.AddComment(new Comment("John", "I learned something useful today."));
        video1.AddComment(new Comment("Sarah", "Please share more tutorials like this."));


        // Add comments to video 2
        video2.AddComment(new Comment("Greg", "This tutorial helped me understand web development."));
        video2.AddComment(new Comment("David", "Very helpful explanation!"));
        video2.AddComment(new Comment("Nehemiah", "I enjoyed this lesson."));


        // Add comments to video 3
        video3.AddComment(new Comment("Peter", "Object-oriented programming is interesting."));
        video3.AddComment(new Comment("Mary", "This makes programming easier to understand."));
        video3.AddComment(new Comment("James", "I look forward to learning more."));


        // Add comments to video 4
        video4.AddComment(new Comment("Daniel", "GitHub is a great tool for developers."));
        video4.AddComment(new Comment("Esther", "Thanks for explaining version control."));
        video4.AddComment(new Comment("Paul", "This tutorial was very useful."));


        // Create a list to store the videos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            // Display all comments for the current video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentText());
            }

            Console.WriteLine();
        }
    }
}