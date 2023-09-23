using System;

class Kh_program
{
    static void Main(string[] args)
    {
        // Introducing the user to the program.
        Console.WriteLine("Welcome to the Guess My Number Game!");
        Console.WriteLine("Enter your guesses below.");
        Console.WriteLine("");

        // Making a randomly generated number for the user to guess. (1-303).
        Random kh_randomGenerator = new Random();
        int kh_magic_number = kh_randomGenerator.Next(1, 303);

        int kh_guessed_number = -1;
        
        // Making a while loop to do these actions below until the user guessed number equals the randomly generated one.
        while (kh_guessed_number != kh_magic_number)
        {
            // Asking the user for a guess.
            Console.Write("What is your guess?: ");

            // Putting the guessed number into a variable and turning it into an int.
            kh_guessed_number = int.Parse(Console.ReadLine());
            
            // Giving the user feedback to tell if the number they guessed is lower or higher than the magic number.
            if (kh_guessed_number < kh_magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (kh_guessed_number > kh_magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You've guessed it!");
            }
        }
    }
}