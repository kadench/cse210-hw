using System;
using System.Globalization;

class Kh_program
{
    static void Main(string[] args)
    {
        // Introducing the user to the program.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Creating the numbers list to append the users given numbers.
        List<float> kh_numbers;
        kh_numbers = new List<float>();

        // Assigning the kh_number_to_average variable before I start the do-while loop.
        float kh_number_to_average = 1;
        
        // Setting the largest number from the list variable.
        float kh_largest_number = 0;

        // Ask for an float until the user types "0".
        do {
            // Asking the user for an float.
            Console.Write("Enter an float: ");

            // Changing the user input into an float.
            kh_number_to_average = int.Parse(Console.ReadLine());

            // Stopping the loop if float = 0
            if (kh_number_to_average != 0)
            {

            // Adding the float to the kh_numbers list.
            kh_numbers.Add(kh_number_to_average);
            }
            

            } while (kh_number_to_average != 0);
        
        // Define the number total before adding all the other floats to it. 
        float kh_number_total = 0;

        // Going through all the saved numbers in the kh_numbers list and adding them to one variable.
        foreach (float kh_number in kh_numbers)
        {
            // Adding the specific number to the number total.
            kh_number_total = kh_number_total + kh_number;
            
            if (kh_number > kh_largest_number)
            {
                kh_largest_number = kh_number;
            }
        }

        // Setting the total number amount from the list.
        float kh_number_count = kh_numbers.Count;
        
        // Averaging the kh_number_total and displaying it to the user.
        float kh_average = kh_number_total / kh_number_count;
        Console.WriteLine($"The sum is: {kh_number_total}");
        Console.WriteLine($"The average is: {kh_average}");
        Console.WriteLine($"The largest number is: {kh_largest_number}");
    }
}