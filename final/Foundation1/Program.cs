using System;

class Program
{
     static void Main(string[] args)
     {
        List<Video> videos = new List<Video>();
        Video V1 = new Video("Exhibition 33", "Breanna Russell", 1080);
        V1.ACom(new Comment("Lydia", "You're so good at the game!"));
        V1.ACom(new Comment("Saul", "Never played the game, but you've inspired me to try it."));
        V1.ACom(new Comment("Emilon", "Fire game, the graphics are sick!"));
        videos.Add(V1);
        Video V2 = new Video("The Ways of Dr. Pepper", "Heidi Russell", 387);
        V2.ACom(new Comment("William", "Dr Pepper is easily the best drink around!"));
        V2.ACom(new Comment("Hailie", "I used to think energy drinks were the way, but Dr Pepper clearly got the upper hand."));
        V2.ACom(new Comment("Bethany", "Dr Pepper is so good!"));
        videos.Add(V2);
        Video V3 = new Video("Painting", "McKayla Russell", 300);
        V3.ACom(new Comment("Diana", "You're so good with leather paints!"));
        V3.ACom(new Comment("Amber", "You slayed at World Cosplay Summit!"));
        V3.ACom(new Comment("Wakina", "It was so fun to learn from you!"));
        videos.Add(V3);
        Video V4 = new Video("Family Home Evening", "AnneMaria Russell", 3600);
        V4.ACom(new Comment("Fay", "Got some great Idea's!"));
        V4.ACom(new Comment("Alex", "Thanks for posting!"));
        V4.ACom(new Comment("Ronan", "I love Come Follow Me"));
        V4.ACom(new Comment("Asher", "Primary is my favorite!"));
        V4.ACom(new Comment("Leo", "Can't wait to serve a mission!"));
        videos.Add(V4);
        foreach (Video video in videos){
            Console.WriteLine($"Title: {video.GTitle()}");
            Console.WriteLine($"Author: {video.GAuthor()}");
            Console.WriteLine($"Length: {video.GLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GComCount()}");
            Console.WriteLine("Comments: ");
            foreach (Comment comment in video.GComments())
            {
                Console.WriteLine($"{comment.GComName()}: {comment.GComText()}");
            }
            Console.WriteLine();
        }
     }
}

