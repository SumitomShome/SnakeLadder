using System;
namespace SnakeAndLadder
{
    class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int StartPosition = 0;
        public const int WinningPosition = 100;
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
                    break;
                case Ladder:
                    addNumber = numberOnDie;
                    break;
                case Snake:
                    addNumber = -numberOnDie;
                    break;
            }
            return addNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            //Initializing
            int currentPosition = 0;
            int nextPosition;
            int count = 0;
            int numberOnDie = rollDie();
            while (currentPosition < WinningPosition)
            {
                numberOnDie = rollDie();
                count++;
                int addNumber = newPosition(numberOnDie);
                nextPosition = currentPosition + addNumber;
                if (nextPosition <0)
                {
                    currentPosition = 0;
                }
     		 else if (nextPosition > WinningPosition)
                {
                    nextPosition = currentPosition;
                }
                else
                {
                    currentPosition = nextPosition;
                }
            }
            Console.WriteLine("Number of times the die rolled is : " + count);
            Console.WriteLine("Final position is: " + currentPosition);
            Console.ReadKey();
        }
    }
}
