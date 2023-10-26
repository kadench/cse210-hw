using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment khAssignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(khAssignment1.GetSummary());

        MathAssignment khAssignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(khAssignment2.GetSummary());
        Console.WriteLine(khAssignment2.GetHomeworkList());
    
        WritingAssignment khAssignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(khAssignment3.GetSummary());
        Console.WriteLine(khAssignment3.GetWritingInformation());
    }
}