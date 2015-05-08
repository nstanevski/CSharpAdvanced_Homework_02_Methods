using System;
using System.Linq;

/*
 * Write a method that checks if the element at given position 
 * in a given array of integers is larger than its two neighbours
 * (when such exist).
 */


class LargerThanNeighbours
{
    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        //check first element:
        if(i==0){
            if(numbers[0]>numbers[1])
                return true;
            else
                return false;
        }

        //check last element
        if (i == numbers.Length-1)
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

    static void Main()
    {
        Console.Write("Please, enter a sequence of space-separated integers: ");
        int[] numbers = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }

    }
}