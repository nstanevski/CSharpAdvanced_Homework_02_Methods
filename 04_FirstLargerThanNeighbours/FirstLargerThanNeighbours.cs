using System;
using System.Linq;

/*
 * Write a method that returns the index of the first element in array that is larger
 * than its neighbours, or -1 if there's no such element. Use the method 
 * from the previous exercise
 */

class FirstLargerThanNeighbours
{
    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        //check first element:
        if (i == 0)
        {
            if (numbers[0] > numbers[1])
                return true;
            else
                return false;
        }

        //check last element
        if (i == numbers.Length - 1)
        {
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                return true;
            else
                return false;
        }

        //check other elements
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            return true;
        else
            return false;
    }

    private static int GetFirstElementLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargerThanNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Please, enter a sequence of space-separated integers: ");
        int[] numbers = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).ToArray();
        int indexFirstLarger = GetFirstElementLargerThanNeighbours(numbers);
        Console.WriteLine("Index of first larger element: " + indexFirstLarger);
    }
}