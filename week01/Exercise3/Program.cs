using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess;
        int numberOfGuess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guessText = Console.ReadLine();
            guess = int.Parse(guessText);
            numberOfGuess += 1;
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
        Console.WriteLine($"It took you {numberOfGuess} guesses.");
    }
}