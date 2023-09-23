using System;

class Program
{
    static void Main(string[] args)
    {
        // Introducing the user to the program.
        Console.WriteLine("Welcome to the Guess My Number Game!");
        Console.WriteLine("Enter your guesses below.");
        Console.WriteLine("");

        // Making a randomly generated number for the user to guess. (1-25).
        Random kh_randomGenerator = new Random();
        int kh_magic_number = kh_randomGenerator.Next(1, 25);

        int kh_guessed_number = -1;
        
        // Making a while loop to do these actions below until the user guessed number equals the randomly generated one.
        // (Took forever to figure this one out because I was trying to use a do while loop. I need more clarification on those if we are ever to use them.)
        while (kh_guessed_number != kh_magic_number)
        {
            // Asking the user for a guess.
            Console.Write("What is your guess?: ");

            // Putting the guessed number into a variable and turning it into an int.
            int kh_guessed_number = int.Parse(Console.ReadLine());
            
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