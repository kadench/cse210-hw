using System;

class Program
{
        static void Main(string[] args)
    {
        Fraction kh_fraction1 = new Fraction();
        Fraction kh_fraction2 = new Fraction(5);
        Fraction kh_fraction3 = new Fraction(3, 4);
        Fraction kh_fraction4 = new Fraction(1, 3);

        Console.WriteLine(kh_fraction1.khGetFractionString());
        Console.WriteLine(kh_fraction1.khGetDecimalValue());
        Console.WriteLine(kh_fraction2.khGetFractionString());
        Console.WriteLine(kh_fraction2.khGetDecimalValue());
        Console.WriteLine(kh_fraction3.khGetFractionString());
        Console.WriteLine(kh_fraction3.khGetDecimalValue());
        Console.WriteLine(kh_fraction4.khGetFractionString());
        Console.WriteLine(kh_fraction4.khGetDecimalValue());
    }
}