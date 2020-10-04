using System;

namespace UC6
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is for an individual player. 
            //Initialisation and welcome message
            Console.WriteLine("Welcome to Snakes and Ladders Problem");
            int position = 0;

            Random r = new Random();

            String[] boardMoves = { "No Play", "Snake", "Ladder" };
            Random rand = new Random();
            int turn = 1;

            while (position < 100)

            {
                int diceMove = r.Next(1, 7);
                int index = rand.Next(boardMoves.Length);
                switch (index)
                {
                    //In case of snake
                    case 1:
                        position = position - diceMove;
                        turn++;
                        break;
                        //In case of ladder
                    case 2:
                        position = position + diceMove;
                        turn++;
                        break;
                        //In case of no play
                    default: break;
                }
                if (position < 0)
                {
                    position = 0;
                }
                if (position > 100)
                {
                    position = position - diceMove;
                }
                //Keeping track of the positions and die turns
                Console.WriteLine("Your new position: {0}", +position+ " and the dice rolled for" +turn+ "times");
            }

        }
    }
}
