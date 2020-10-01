using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            //Initializing
            int currentPosition = 0;
            Console.WriteLine("Starting position is : " + currentPosition);
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            Console.WriteLine("Number on the die rolled is : " + numberOnDie);
            Console.ReadKey();
        }
    }
}

