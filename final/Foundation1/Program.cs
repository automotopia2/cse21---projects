using System;

class Program
{
    static void Main(string[] args)
    {
        VideoLibrary videos = new VideoLibrary();
        Video video1 = new Video("I Love Snakes", "Jimmy Carlo", 200);
        Comment comment1 = new Comment("TheRealKevinDurant","I can't watch...");
        Comment comment2 = new Comment("FreshKiwi509","Your content is why I believe snakes are the true species that should rule the world.");
        Comment comment3 = new Comment("Baconator25","That is so creepy. That snake literally wants to eat you.");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        
        Video video2 = new Video("I Hate Snakes", "Joe Como", 500);
        Comment comment4 = new Comment("EdamameEater","Hey stop picking on snakes like that! My snake is better than my friends.");
        Comment comment5 = new Comment("WestonWednesday921","You are such a cruel person. Snakes should never be put in cages. #freethesnakes");
        Comment comment6 = new Comment("SnakeEater2605","Dang that snake is looking really delicious.");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("I Want Frogs", "Hailee Bailee", 450);
        Comment comment7 = new Comment("Froglover2002","You are my favorite YouTuber! Please keep making my day better!");
        Comment comment8 = new Comment("Frogsforsale902","African tree frogs: only $12.99! Click the link below to see what we are selling!");
        Comment comment9 = new Comment("IeatLemons9090","That is the cutest frog I have ever seen. I wish someone was selling this type of frog...");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        
        videos.AddVideo(video1);
        videos.AddVideo(video2);
        videos.AddVideo(video3);

        videos.DisplayVideos();
    }
}