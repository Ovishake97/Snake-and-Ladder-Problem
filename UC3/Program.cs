using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation and welcome message
            Console.WriteLine("Welcome to Snakes and Ladders Problem");
            int position = 0;
            Random r = new Random();
            int diceMove = r.Next(1, 7);

            String[] boardMoves = { "No Play", "Snake", "Ladder" };
            Random rand = new Random();
            int index = rand.Next(boardMoves.Length);
            Console.WriteLine($"Obtanined move is {boardMoves[index]}");
            switch (index)
            {
                //In case of snake
                case 1:
                    position = position - diceMove;
                    break;
                    //In case of ladder
                case 2:
                    position = position + diceMove;
                    break;
                    //In cas eof no play
                default: break;
            }
            if (position < 0)
            {
                position = 0;
            }
            //To print positions
            Console.WriteLine("Your new position: {0}", +position);
        }
    }
    }

