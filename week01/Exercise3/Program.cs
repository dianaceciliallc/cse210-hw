using System;

class Program
{
    static void Main(string[] args)
    {
        string keep_playing = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guesses = 0;

        while ( keep_playing == "yes")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guess_to_int = int.Parse(guess);

            if ( guess_to_int > number )
            {
                Console.WriteLine("Lower");
                guesses++;
            }
            else if ( guess_to_int < number )
            {
                Console.WriteLine("Higher");
                guesses++;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You have guessed {guesses} times.");

                Console.Write("Do you want to keep playing?(yes/no) ");
                keep_playing = Console.ReadLine();
                if ( keep_playing == "yes")
                {
                    number = randomGenerator.Next(1, 101);
                    guesses = 0;
                }
            }
        }
    }
}