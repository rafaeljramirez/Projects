using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;

            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose between Rock, Paper, and Scissors:");
                    inputPlayer = Console.ReadLine();
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("Computer chose Rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player Wins!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("Computer chose Paper");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Draw!! \n\n");
                            }

                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("Computer chose Scissors");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!!");
                            break;
                    }
                    Console.WriteLine("\n\nScores: \tPlayer: \t{0} \tCPU: \t{1}",
                        scorePlayer, scoreCPU);

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player Won!");
                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU Won!");
                    }
                    else
                    {

                    }  
                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}

