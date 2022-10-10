using System;

namespace TicTacToe
{
    class Program
    {
        // the playfield
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();
            Console.ReadKey();

            //Run code as long as the program runs
            do
            {
                if (player == 2)
                    player = 1;
                else if (player == 1)
                    player = 2;


                switch (player)
                {
                    case 1: // Player 1's turn
                        {
                            switch (input)
                            {
                                case 1: playField[0, 0] = 'X'; break;
                                case 2: playField[0, 1] = 'X'; break;
                                case 3: playField[0, 2] = 'X'; break;
                                case 4: playField[1, 0] = 'X'; break;
                                case 5: playField[1, 1] = 'X'; break;
                                case 6: playField[1, 2] = 'X'; break;
                                case 7: playField[2, 0] = 'X'; break;
                                case 8: playField[2, 1] = 'X'; break;
                                case 9: playField[2, 2] = 'X'; break;
                            }
                            break;
                        }
                    case 2: // Player 2's turn
                        {
                            switch (input)
                            {
                                case 1: playField[0, 0] = 'X'; break;
                                case 2: playField[0, 1] = 'X'; break;
                                case 3: playField[0, 2] = 'X'; break;
                                case 4: playField[1, 0] = 'X'; break;
                                case 5: playField[1, 1] = 'X'; break;
                                case 6: playField[1, 2] = 'X'; break;
                                case 7: playField[2, 0] = 'X'; break;
                                case 8: playField[2, 1] = 'X'; break;
                                case 9: playField[2, 2] = 'X'; break;
                            }
                            break;
                        }
                }


            } while (true);

            SetField();
            Console.ReadLine();
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |      ");
            //Todo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //Todo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //Todo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }

    }
}
