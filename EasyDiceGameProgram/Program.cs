using System;

namespace EasyDiceGameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int computerRandomNum;

            int playerPoint = 0;
            int computerPoint = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("\nYou rolled a " + playerRandomNum);

                Console.WriteLine("..................");
                System.Threading.Thread.Sleep(1000);

                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + computerRandomNum);

                if (playerRandomNum > computerRandomNum)
                {
                    playerPoint++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < computerRandomNum)
                {
                    computerPoint++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now -> Player: " + playerPoint + " | Enemy: " + computerPoint);
                Console.WriteLine();
            }

            if (playerPoint > computerPoint)
            {
                Console.WriteLine("You win, congratulations!");
            }
            else if (playerPoint < computerPoint)
            {
                Console.WriteLine("You lose, better luck next time.");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadKey();
        }
    }
}
