using System;
using System.Globalization;

namespace SLProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation and welcome message
            Console.WriteLine("Welcome to Snakes and Ladders Problem");
            const int INITIAL_POSITION = 0;
            const int N0_OF_PLAYERS = 2;
            //Assigning arrays to store the positions and the die turns of individual players
            Random rnd = new Random();
            int[] turn = new int[N0_OF_PLAYERS];
            int diceMove;
            int index;
            int j = 0;
            int[] playerPosition = new int[N0_OF_PLAYERS];
            String[] boardMoves = { "No Play", "Snake", "Ladder" };
            Random rand = new Random();
            for (int i = 0; i < N0_OF_PLAYERS; i++)
            {
                playerPosition[i] = INITIAL_POSITION;
                turn[i] = 1;
            }


            while (playerPosition[j] < 100)

            {

                diceMove = rnd.Next(1, 7);
                index = rand.Next(boardMoves.Length);
                switch (index)
                {
                    //In case of snake
                    case 1:
                        playerPosition[j] = playerPosition[j] - diceMove;
                        turn[j]++;
                        break;
                        // In case of ladder
                    case 2:

                        playerPosition[j] = playerPosition[j] + diceMove;
                        turn[j]++;
                        break;

                        // In case of No play
                    default: break;
                }
                diceMove = 0;
                index = 0;
                if (playerPosition[j] < 0)
                {
                    playerPosition[j] = 0;
                }
                if (playerPosition[j] > 100)
                {
                    playerPosition[j] = playerPosition[j] - diceMove;
                }

                //Keeping track of Individual player positions and die turns
                Console.WriteLine("New position of Player: {0}" + (j + 1) + " is " + playerPosition[j] + " and the dice rolled for " + turn[j] + " times");

                //Declaring the winner
                if (playerPosition[j] == 100)
                {
                    Console.WriteLine("Winner of the game is Player:{0}" + (j + 1));
                    break;
                }
                if (j == N0_OF_PLAYERS - 1)
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
            }


        }
    } 
        }
           
        
    

