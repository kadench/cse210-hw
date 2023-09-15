using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1
        // Console.Write("What is your first name?: ");
        // string kh_first_name = Console.ReadLine();
        // Console.Write("What is your last name?: ");
        // string kh_last_name = Console.ReadLine();
        // Console.WriteLine($"Your name is {kh_last_name}, {kh_first_name} {kh_last_name}");
        // Part 2
        
        Console.Write("Enter grade value: ");
        string kh_grade_from_user = Console.ReadLine();
        int kh_grade_value_as_int = int.Parse(kh_grade_from_user);
        if (kh_grade_value_as_int >= 90)
        {
            Console.WriteLine("You have an A.");
        }
        else if (kh_grade_value_as_int >= 80)
        {
            Console.WriteLine("You have an B.");
        }
        else if (kh_grade_value_as_int >= 70)
        {
            Console.WriteLine("You have an C.");
        }
        else if (kh_grade_value_as_int >= 60)
        {
            Console.WriteLine("You have an D.");
        }
        else if (kh_grade_value_as_int < 60)
        {
            Console.WriteLine("You have an F.");
        }
        else
        {
            Console.WriteLine("You didn't enter a number.");
        }

    }
}