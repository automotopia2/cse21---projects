using System;

class Program
{
    static void Main(string[] args)
    {
        VideoLibrary videos = new VideoLibrary();
        Video video1 = new Video("I Love Snakes", "Jimmy Carlo", 200);
        Comment comment1 = new Comment("","");
        Comment comment2 = new Comment("","");
        Comment comment3 = new Comment("","");

        Video video2 = new Video("I Hate Snakes", "Joe Como", 500);
        Comment comment4 = new Comment("","");
        Comment comment5 = new Comment("","");
        Comment comment6 = new Comment("","");

        Video video3 = new Video("I Want Frogs", "Hailee Bailee", 450);
        Comment comment7 = new Comment("","");
        Comment comment8 = new Comment("","");
        Comment comment9 = new Comment("","");
        
    }
}