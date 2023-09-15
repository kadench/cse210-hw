using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string kh_first_name = Console.ReadLine();
        Console.Write("What is your last name?: ");
        string kh_last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {kh_last_name}, {kh_first_name} {kh_last_name}");
    }
}