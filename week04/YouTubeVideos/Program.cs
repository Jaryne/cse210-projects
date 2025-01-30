using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Class Video
        // Title, author, length in seconds
        // Store list of comments
        // method to display list of comments
        // method to display count of comments

        // Class Comments
        // attritbutes(text in comment)
        // track name of author

        // Notes from team meeting:
        // ctrl + / to comment highlights
        // alt + shift + f  to format
        // ctrl + d  will rewrite all highlighted
        // ctrl + l to.. i forgot.

        // Video List
        Video video1 = new Video("Ekko Theory", "Arcane", 1260);
        Video video2 = new Video("SpiderPool", "Marvel", 616);
        Video video3 = new Video("How to say library in different languages?", "Duolinguini", 123);
        Video video4 = new Video("Ekko's Guide", "Arcane", 444);

        // Comments
        video1.AddComment(new Comment("Simon", "There are no facts, only interpretations."));
        video1.AddComment(new Comment("Apollo", "Sometimes the most unexpected witnesses hold the key to unlocking the truth."));
        video1.AddComment(new Comment("Wright", "OBJECTION!"));

        video2.AddComment(new Comment("Reynolds", "Perhaps."));
        video2.AddComment(new Comment("Peter", "No...just.. no."));
        video2.AddComment(new Comment("Ryan", "Perhaps."));
        video2.AddComment(new Comment("Jack", "..."));

        video3.AddComment(new Comment("Texas", "biblioteka"));
        video3.AddComment(new Comment("Pedro", "aklatan"));
        video3.AddComment(new Comment("Ryan", "bibliotheque"));
        video3.AddComment(new Comment("Jaime", "escuela"));

        video4.AddComment(new Comment("Violet", "Always be our little man."));
        video4.AddComment(new Comment("IAMEkko", "At least I don't block with my face."));
        video4.AddComment(new Comment("Powder", "There. One second."));

        // Store videos in list
        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        // Display
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        
        }

   }
}