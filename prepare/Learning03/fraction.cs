using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor that initializes the number to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor that takes one parameter for the top and initializes the denominator to 1
    public Fraction(int kh_wholeNumber)
    {
        _numerator = kh_wholeNumber;
        _denominator = 1;
    }

    // Constructor that takes two parameters for the top and the bottom
    public Fraction(int kh_top, int kh_bottom)
    {
        _numerator = kh_top;
        _denominator = kh_bottom;
    }

    public string khGetFractionString()
    {
        string kh_fractionText = $"{_numerator}/{_denominator}";
        return kh_fractionText;
    }

    public double khGetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}