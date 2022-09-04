using System;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human raginee = new Human();
            //raginee.firstName = "Raginee";
            //raginee.lastName = "Gupta";
            //raginee.IntroduceMyself();

            Human raginee = new Human("Raginee", "Gupta", "Black", 24);
            raginee.IntroduceMyself();

            Human ashwini = new Human("Ashwini", "Gawad", "Black");
            ashwini.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
