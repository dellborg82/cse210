using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> _listOfVideos = new List<Video>();

       Video vid1 = new Video("Introduction to Ham Radio", "Ebby Anne", 1024);
       Comment vid1comm1 = new Comment("John Smith", "Wow, who knew Ham Radio could do so much!");
       vid1.AddCommentToVideo(vid1comm1);
       Comment vid1comm2 = new Comment("Brigham Young", "Wow, you mean I can talk to the astronauts on the International Space Station!");
       vid1.AddCommentToVideo(vid1comm2);
       Comment vid1comm3 = new Comment("Ham Radio Guy", "Hey, Great Introduction video for those who are looking for information on the hobby!");
       vid1.AddCommentToVideo(vid1comm3);
       _listOfVideos.Add(vid1);

       Video vid2 = new Video("Introduction to the Artemis Spaceship Bridge Simulator", "Artemis Admin", 2048);
       Comment vid2comm1 = new Comment("Larry", "Wow, You mean I can be the Captain of my own starship, like Captain Kirk?");
       vid2.AddCommentToVideo(vid2comm1);
       Comment vid2comm2 = new Comment("Curly", "Wow, This looks like so much fun. I'll have to get some friends together and play");
       vid2.AddCommentToVideo(vid2comm2);
       Comment vid2comm3 = new Comment("Moe", "It looks like this can be used for educational purposes and can be used as a team building exercise!");
       vid2.AddCommentToVideo(vid2comm3);
       _listOfVideos.Add(vid2);
     
       Video vid3 = new Video("Introduction to Python", "Python Programming", 1592);
       Comment vid3comm1 = new Comment("John Doe", "Wow, who knew python could do so much!");
       vid3.AddCommentToVideo(vid3comm1);
       Comment vid3comm2 = new Comment("Jane Doe", "Wow, this looks like a versatile languange. Thanks for sharing!");
       vid3.AddCommentToVideo(vid3comm2);
       Comment vid3comm3 = new Comment("Mr. Anderson", "Do yo know if it can do Machine Learning?");
       vid3.AddCommentToVideo(vid3comm3);
       Comment vid3comm4 = new Comment("Data", "This looks like it could be a lot of fun to learn!");
       vid3.AddCommentToVideo(vid3comm4);
       _listOfVideos.Add(vid3);

       foreach (Video video in _listOfVideos)
       {
        video.Display();
       }
        
    }
}