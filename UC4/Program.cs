using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiaalisation and welcome message  
            Console.WriteLine("Welcome to Snakes and Ladders Problem");
            int position = 0;

            Random r = new Random();

            String[] boardMoves = { "No Play", "Snake", "Ladder" };
            Random rand = new Random();

            while (position < 100)

            {   //Assigning die moves and player positions
                int diceMove = r.Next(1, 7);
                int index = rand.Next(boardMoves.Length);
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
                        //In case of no play
                    default: break;
                }
                if (position < 0)
                {
                    position = 0;
                }
                //Printing positions
                Console.WriteLine("Your new position: {0}", +position);
            }

        }
    }
}
