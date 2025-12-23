using System;

namespace NumberGuess
{
    class Program
    {
        static void Main (string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " & " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess :" + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " Is Too high");
                    } 
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " Is Too Low");
                    }
                    guesses++;

                }

                Console.WriteLine("Number :" + number);
                Console.WriteLine("You Win");
                Console.WriteLine(guesses);

                Console.WriteLine("would you like to play again? (Y/N) : ");
                response = Console.ReadLine();
                response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for Playing");




            Console.ReadKey();
        }
    }
}
