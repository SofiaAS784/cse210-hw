using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to become a web developer in 30 days", "XBSC1234", 862);
        Comment comment1V1 = new Comment("Alex V", "Great video, I love it!");
        video1.AddComment(comment1V1);
        Comment comment2V1 = new Comment("Jason Muller", "How can I download that app?");
        video1.AddComment(comment2V1);
        Comment comment3V1 = new Comment("AshRux", "Do you have any videos explaining better how to update your web site with information in real time once is updated?");
        video1.AddComment(comment3V1);

        Video video2 = new Video("Passing Minecraft in one day", "TheGreatGamer784", 9567);
        Comment comment1V2 = new Comment("CreeperXvZS", "Add me to your friends!");
        video2.AddComment(comment1V2);
        Comment comment2V2 = new Comment("S123", "I love that trick, is insane.");
        video2.AddComment(comment2V2);
        Comment comment3V2 = new Comment("Greed134", "Greetings from Chile");
        video2.AddComment(comment3V2);

        Video video3 = new Video("Making a song in the style of...", "Rupert Hoover", 572);
        Comment comment1V3 = new Comment("Mike Tyson", "You have a great style dude!");
        video3.AddComment(comment1V3);
        Comment comment2V3 = new Comment("Olivia Perez", "I played it in Spotify 1 million times by now!");
        video3.AddComment(comment2V3);
        Comment comment3V3 = new Comment("Vorterix1", "We keep waiting for you in Alabama. We want to listen to your songs in live!");
        video3.AddComment(comment3V3);

        Video video4 = new Video("50 italian expressions you should know", "Imparando Italiano", 1230);
        Comment comment1V4 = new Comment("GeniusBoy", "I am going to Rome next year. Ci vediamo lí!");
        video4.AddComment(comment1V4);
        Comment comment2V4 = new Comment("Aaron Johnson", "Good lesson. I can't wait for the next one.");
        video4.AddComment(comment2V4);
        Comment comment3V4 = new Comment("Thomas Lim", "I just bought your new course. It's awesome!");
        video4.AddComment(comment3V4);
        Comment comment4V4 = new Comment("Angelo Di Verni", "Insegni molto bene. Spero di vederti a Roma presto.");
        video4.AddComment(comment4V4);

        video1.DisplayAll();
        video2.DisplayAll();
        video3.DisplayAll();
        video4.DisplayAll();
    }
}