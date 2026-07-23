using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Nine In The Afternoon", "Panic! At The Disco", 600);
        video1.AddComment(new Comment("Carlos", "Nice song 🎉🎉!"));
        video1.AddComment(new Comment("Maria99", "Sunshine"));
        video1.AddComment(new Comment("DevGuru", "Best panic at the disco in my opinion"));
        videos.Add(video1);

        Video video2 = new Video("Pomodoro timer 2x50", "LIVE Mr. Tiny's Studio", 2000);
        video2.AddComment(new Comment("bunnybutsy", "I am finally Locking In 🎉🎉!"));
        video2.AddComment(new Comment("LazerbeakK", "AND GOOD LUCK TO ALL THOSE THAT ARE STUDYING!"));
        video2.AddComment(new Comment("captain", "the concerning part should be most replayed is at the 10 min break part"));
        videos.Add(video2);

        Video video3 = new Video("SUMMER", "HALCALI", 180);
        video3.AddComment(new Comment("JojoBO", "the end of summer"));
        video3.AddComment(new Comment("user-mirumiru", "Vibe: 100%"));
        video3.AddComment(new Comment("pawslex", "THIS SUMMER"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.GetDisplay();
            Console.WriteLine(new string('-', 80));
        }
    }
}