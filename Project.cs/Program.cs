using System;
namespace SnakeAndLadder
{
    class Program
    {
       static void Main(string[] args)
        {
            const int noPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            const int WinningPosition = 100;
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            int player = 0;
            int[] playerPosition = new int[2] { 0, 0 };
            int count = 0;
            while (playerPosition[player] < WinningPosition)
            {
                Random random = new Random();
                int numberOnDie = random.Next(1, 7);
                count++;
                int optionCheck = random.Next(0, 3);
                switch (optionCheck)
                {
                    case noPlay:
                        break;
                    case Ladder:
                        if (playerPosition[player] + numberOnDie <= 100)
                        {
                            playerPosition[player] = playerPosition[player] + numberOnDie;
                        }
                        break;
                    case Snake:
                        if (playerPosition[player] < 0)
                        {
                            playerPosition[player] = 0;
                        }
                        break;
                }
                if (optionCheck == noPlay || optionCheck == Snake)
                {
                    if (player == 0)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 0;
                    }
                }
            }
                Console.WriteLine("Player : " + player + " wins the die roll:" + count);
                Console.ReadKey();
        }
    }

}
