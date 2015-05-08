using System;

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
