using System;

/*
 * Write a method that reverses the digits of a given floating-point number.
 */

class ReverseNumber
{
    private static string ReverseString(string str)
    {
        if (str == null) 
            return "";
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
    
    private static double GetReversedNumber(double num)
    {
        bool isNegative = num >= 0 ? false : true;
        num = Math.Abs(num);
        string numStr = num.ToString();
        numStr = ReverseString(numStr);
        double result = double.Parse(numStr);
        return isNegative ? -result : result;
    }

    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double revNum = GetReversedNumber(num);
        Console.WriteLine(revNum);
    }
}