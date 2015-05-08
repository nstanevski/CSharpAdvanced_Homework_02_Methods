using System;

/*
 * Write a method that returns the last digit of a given integer as an English word. 
 * Test the method with different input values. Ensure you name the method properly.
 */
class LastDigitOfNumber
{
    private static string GetLastDigitAsWord(int num)
    {
        string[] digitWords = { "zero", "one", "two", "three", "four",
                                  "five","six","seven","eight","nine"};

        int remainder = num % 10;

        return digitWords[remainder];
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }
}
