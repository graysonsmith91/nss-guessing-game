using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            int secretNumber = new Random().Next(1, 101);

            Console.WriteLine("Select your difficulty level: 1 is easy, 2 is medium, 3 is hard, 4 if you're a cheater");
            string difficultyInput = Console.ReadLine();
            int parsedDifficultyInput = int.Parse(difficultyInput);

            switch (parsedDifficultyInput)
            {
                case 1:
                    guesses = 8;
                    break;
                case 2:
                    guesses = 6;
                    break;
                case 3:
                    guesses = 4;
                    break;
                case 4:
                    guesses = 99;
                    break;
            }


            for (int i = 1; i <= guesses; i++)
            {
                Console.WriteLine($"Guess #{i}");
                Console.WriteLine("Guess the secret number: ");
                string input = Console.ReadLine();

                if (input.Length > 0)
                {
                    int parsedInput = int.Parse(input);
                    if (secretNumber == parsedInput)
                    {
                        Console.WriteLine("You've got it");
                        break;
                    }
                    else
                    {
                        if (guesses > 90)
                        {
                            i--;
                        }

                        if (secretNumber - parsedInput >= 1)
                        {
                            Console.WriteLine("Too low!");
                        }

                        if (secretNumber - parsedInput < 0)
                        {
                            Console.WriteLine("Too high!");
                        }

                        if (i != guesses)
                        {
                            Console.WriteLine("Guess again");
                            Console.WriteLine();
                        }
                        else if (i == guesses)
                        {
                            Console.WriteLine("Better luck next time :(");
                        }
                    }
                }
            }
        }
    }
}

// bool isNum = int.TryParse(input, out int n);