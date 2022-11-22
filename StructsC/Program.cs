using System;

namespace StructsC
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
        public void Display()
        {
            Console.WriteLine("Gmae 1's name is : {0}", name);
            Console.WriteLine("Gmae 1's developer by : {0}", developer);
            Console.WriteLine("Gmae 1's rating is : {0}", rating);
            Console.WriteLine("Gmae 1 was released in : {0}", releaseDate);

        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "22-11-2022";

            game1.Display();
        }
    }
}
