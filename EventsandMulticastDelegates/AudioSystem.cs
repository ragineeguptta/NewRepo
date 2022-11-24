using System;
using System.Collections.Generic;
using System.Text;

namespace EventsandMulticastDelegates
{
    class AudioSystem
    {
        //simple constructor
        public AudioSystem()
        {
            //simple to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game , we want to enable the audio system amnd start playing audio clops
        private void StartGame()
        {
            Console.WriteLine("Audio System Started ");
            Console.WriteLine("Playing Audio........");
        }

        //when the game is over, we want to stop our rendring engine
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
