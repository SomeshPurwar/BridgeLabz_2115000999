using System;

public class GuessingGame
{
    public static void print()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it. Hit Enter!!");
		Console.ReadKey();
        Console.WriteLine("After each guess, please tell me whether my guess is 'high', 'low', or 'correct'.");

        int lowerBound = 1;
        int upperBound = 100;
        int guess;
        string feedback;

        while (true)
        {
            guess = GenerateGuess(lowerBound, upperBound);
            Console.WriteLine($"My guess is: {guess}");

            feedback = GetUserFeedback();

            if (feedback.ToLower() == "correct")
            {
                Console.WriteLine("Yay! I guessed your number correctly!");
                break;
            }
            else if (feedback.ToLower() == "high")
            {
                upperBound = guess - 1;
            }
            else if (feedback.ToLower() == "low")
            {
                lowerBound = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid feedback. Please respond with 'high', 'low', or 'correct'.");
            }
        }
    }

    static int GenerateGuess(int lowerBound, int upperBound)
    {
        Random random = new Random();
        return random.Next(lowerBound, upperBound + 1);
    }

    static string GetUserFeedback()
    {
        Console.Write("Is my guess high, low, or correct? ");
        return Console.ReadLine();
    }
}
