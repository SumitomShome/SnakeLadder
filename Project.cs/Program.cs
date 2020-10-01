using System;
namespace SnakeAndLadder
{
    class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public static int rollDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        public static int newPosition(int numberOnDie)
        {
            int addNumber = 0;
            Random random = new Random();
            int optionCheck = random.Next(0, 3);
            switch (optionCheck)
            {
                case NoPlay:
                    Console.WriteLine("No play!");
                    break;
                case Ladder:
                    addNumber = numberOnDie;
                    Console.WriteLine("Ladder, so moving forward!");
                    break;
                case Snake:
                    addNumber = -numberOnDie;
                    Console.WriteLine("Snake, so moving backward!");
                    break;
            }
            return addNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            //Initializing
            int currentPosition = 0;
            Console.WriteLine("Starting position: " + currentPosition);
            int numberOnDie = rollDie();
            Console.WriteLine("Number on the die rolled is : " +numberOnDie);
            Console.WriteLine("New position is: " + newPosition(numberOnDie));
            Console.ReadKey();
        }
    }
}

