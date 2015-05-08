using System;

/*
 * Write a method which takes an array of any type and sorts it. 
 * Use bubble sort or selection sort (your own implementation). 
 * You may re-use your code from a previous homework and modify it. 
 * Use a generic method (read in Internet about generic methods in C#). 
 * Make sure that what you're trying to sort can be sorted – 
 * your method should work with numbers, strings, dates, etc., 
 * but not necessarily with custom classes like Student.
 */

class GenericArraySort
{
    private static void GenericBubbleSort<T>(ref T[] genericArr) where T : IComparable
    {
        int len = genericArr.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len-1; j++)
            {
                if (genericArr[j].CompareTo(genericArr[j+1]) > 0)
                {
                    T temp = genericArr[j];
                    genericArr[j] = genericArr[j+1];
                    genericArr[j+1] = temp;
                }
            }
        }
    }



    static void Main()
    {
        String line="";
        DateTime[] dates = 
        {
            new DateTime(1969,7,8), new DateTime(1970,12,1), new DateTime(2005,11,22)
        };
        GenericBubbleSort(ref dates);
        line = string.Join(", ", dates);
        Console.WriteLine(line);
        
        int[] intArr = new int[] { -5, 8, 2, -1, 5, 0, 7};
        GenericBubbleSort(ref intArr);
        line = string.Join(", ", intArr);
        Console.WriteLine(line);

        string[] names = new string[] {"John", "Peter", "Alex", "Иван", "Петър", "Алекс" };
        GenericBubbleSort(ref names);
        line = string.Join(", ", names);
        Console.WriteLine(line);
    }
}