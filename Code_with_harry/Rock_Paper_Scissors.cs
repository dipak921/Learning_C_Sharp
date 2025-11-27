using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    internal class Rock_Paper_Scissors
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock paper scissors!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player Score - " + playerScore + ".Enemy Score -" + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy Chooses rock");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy choses paper.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                            case "p":
                            Console.WriteLine("Enmey wins this round.");
                            enemyScore++;
                            break;
                            default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }
            Console.WriteLine("-------------Result-------------------");
            if (playerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose.");
            }


            Console.ReadLine();
        }
    }
}
