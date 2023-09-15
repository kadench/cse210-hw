using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade value: ");
        string kh_grade_from_user = Console.ReadLine();
        int kh_grade_value_as_int = int.Parse(kh_grade_from_user);

        string kh_grade = "";

        if (kh_grade_value_as_int >= 90)
        {
            if (kh_grade_value_as_int >= 97)
            {
                kh_grade = "A+";
            }
            else if (kh_grade_value_as_int <= 93)
            {
                kh_grade = "A-";
            }
            Console.WriteLine($"You have an {kh_grade}.");
        }
        else if (kh_grade_value_as_int >= 80)
        {
            if (kh_grade_value_as_int >= 87)
            {
                kh_grade = "B+";
            }
            else if (kh_grade_value_as_int <= 83)
            {
                kh_grade = "B-";
            }
            Console.WriteLine($"You have an {kh_grade}.");
        }
        else if (kh_grade_value_as_int >= 70)
        {
            if (kh_grade_value_as_int >= 77)
            {
                kh_grade = "C+";
            }
            else if (kh_grade_value_as_int <= 73)
            {
                kh_grade = "C-";
            }
            Console.WriteLine($"You have an {kh_grade}.");
        }
        else if (kh_grade_value_as_int >= 60)
        {
            if (kh_grade_value_as_int >= 67)
            {
                kh_grade = "D+";
            }
            else if (kh_grade_value_as_int <= 63)
            {
                kh_grade = "D-";
            }
            Console.WriteLine($"You have an {kh_grade}.");
        }
        else if (kh_grade_value_as_int < 60)
        {
            Console.WriteLine("You have an F.");
        }
    }
}