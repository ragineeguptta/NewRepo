using System;

namespace InheritaceC
{
    class Program
    {
        static void Main(string[] args)
        {
            ImagePost imagePost = new ImagePost("Check out my new shoes", "Denis Panjuta", "https://image.com/shoes", true);
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagePost.ToString());
            Console.ReadLine();
        }
    }
}
