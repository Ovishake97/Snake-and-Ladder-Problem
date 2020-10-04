using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to Snakes and Ladders Problem");
            int position = 0;

            Random r = new Random();
            int diceMove = r.Next(1, 7);
            Console.WriteLine("Obtained number from the dice: {0}", +diceMove);

        }
    }
}
