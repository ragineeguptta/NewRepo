using System;
using System.Collections.Generic;
using System.Text;

namespace EventsandMulticastDelegates
{
    class GameEventManager
    {
        //a new delegate tye called GameEvent
        public delegate void GameEvent();

        //create two delegates called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        //a static MethodAccessException to trigger OnGameStart
        public static void TrigggerGameStart()
        {
            //check if the OnGameStart event is not empty,
            //meaning that other method already subscribed to it
            if(OnGameStart != null)
            {
                //print a simple message
                Console.WriteLine("The game has started ......");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        //a static Method to trigger OnGameOver
        public static void TrigggerGameOver()
        {
            //check if the TrigggerGameOver event is not empty,
            //meaning that other method already subscribed to it
            if (OnGameOver != null)
            {
                //print a simple message
                Console.WriteLine("The game has started ......");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }

    }
}
