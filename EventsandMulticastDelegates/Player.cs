using System;
using System.Collections.Generic;
using System.Text;

namespace EventsandMulticastDelegates
{
    class Player
    {
        public string PlayerName { get; set; }

        //simple constructor
        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, spawn the player.
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }
        //when game is over, Remove the player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
