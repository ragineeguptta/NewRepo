using System;

namespace InheritaceC
{
    class Program
    {
        static void Main(string[] args)
        {
            ImagePost imagePost = new ImagePost("Check out my new shoes", "Denis Panjuta", "https://image.com/shoes", true);
            VideoPost videoPost1 = new VideoPost("Check out my new video", "Denis Panjuta", "https://video.com/fakevideo", true,10);
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");

            Console.WriteLine(imagePost.ToString());
            Console.WriteLine(videoPost1.ToString());


            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.WriteLine(post1.ToString());
            Console.ReadLine();
        }
    }
}
