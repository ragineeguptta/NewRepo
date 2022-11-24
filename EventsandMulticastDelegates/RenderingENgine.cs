using System;
using System.Collections.Generic;
using System.Text;

namespace EventsandMulticastDelegates
{
    class RenderingENgine
    {
        //simple constructor
        public RenderingENgine()
        {
            //subscribe to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendring Engine Started ");
            Console.WriteLine("Drawing Visuals........");
        }

        //when the game is over, we want to stop our rendring engine
        private void GameOver()
        {
            Console.WriteLine("rRendering Engine Stopped");
        }
    }
}
