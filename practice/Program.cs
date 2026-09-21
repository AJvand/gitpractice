using System;

namespace studio_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Niko's Lab

            {

                {
                    Random random = new Random();
                    int ones = 0;
                    int twos = 0;
                    int threes = 0;
                    int fours = 0;
                    int fives = 0;
                    int sixes = 0;

                    for (int i = 0; i < 6000; i++)
                    {
                        int roll = random.Next(1, 7);

                        if (roll == 1)
                            ones++;
                        else if (roll == 2)
                            twos++;
                        else if (roll == 3)
                            threes++;
                        else if (roll == 4)
                            fours++;
                        else if (roll == 5)
                            fives++;
                        else if (roll == 6)
                            sixes++;
                    }

                    Console.WriteLine("Number     Times Rolled");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1         " + ones);
                    Console.WriteLine("2         " + twos);
                    Console.WriteLine("3         " + threes);
                    Console.WriteLine("4         " + fours);
                    Console.WriteLine("5         " + fives);
                    Console.WriteLine("6         " + sixes);

                    Console.ReadLine();
                    {


                    }
                }
            }
        
    



















































// AJ's Lab
{
    Random rand = new Random();
                double guessTarget = 0;
                double userGuess = -1;
                double attempts = 0;
                string temp = "AAAAAAAAAAAAAAA";

                guessTarget = rand.Next(1, 101);
                Console.WriteLine("Guess a number between 1 and 100");
                temp = Console.ReadLine();
                userGuess = Convert.ToDouble(temp);
                do
                {
                    if (userGuess > guessTarget)
                    {
                        if (attempts == 6)
                        {
                            Console.WriteLine("This is taking a lot of attempts, you should try a better strategy");
                        }
                        Console.WriteLine("You guessed too high, try again");
                        Thread.Sleep(800);
                        attempts = (attempts + 1);
                        Console.WriteLine("Input your guess");
                        temp = Console.ReadLine();
                        Thread.Sleep(800);
                        userGuess = Convert.ToDouble(temp);
                    }

                    else if (userGuess < guessTarget)
                    {
                        if (attempts == 6)
                        {
                            Console.WriteLine("This is taking a lot of attempts, you should try a better strategy");
                        }
                        Console.WriteLine("You guessed too low, try again");
                        Thread.Sleep(800);
                        attempts = (attempts + 1);
                        Console.WriteLine("Input your guess");
                        temp = Console.ReadLine();
                        Thread.Sleep(800);
                        userGuess = Convert.ToDouble(temp);
                    }
                } while (userGuess != guessTarget);
                Thread.Sleep(800);
                Console.WriteLine("Congratulations, you guessed the right number!");
                Console.ReadLine();
            }

















































            // Leivi's Lab
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("*********************************************************");
            Console.WriteLine("*   Leivi                                               *");
            Console.WriteLine("*   1 Nile St                                           *");
            Console.WriteLine("*   My favourite BIT subject is : Programming           *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*********************************************************");
            Console.ReadLine();
        }
    }
}