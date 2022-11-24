using System;

namespace EventsandMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem = new AudioSystem();
            //create a rendering engine
            RenderingENgine renderingENgine = new RenderingENgine();
            //create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TrigggerGameStart();

            Console.WriteLine("Game is Running.... Press any key to end the game.");


            //pause
            Console.Read();

            //trigger gameover event
            GameEventManager.TrigggerGameOver();
        }
    }
}
