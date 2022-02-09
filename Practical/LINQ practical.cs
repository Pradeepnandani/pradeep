using System;
using System.Linq;
class Program
{
    public static void Main()
    {
        int[] nums = { 10, -6, 3, 0, -4, 25 };
        // Query that selects only positive numbers.
        var result = from n in nums
                     where n > 0
                     select n;
        Console.Write("The positive values in nums: ");
        // Execute the query.
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine();
    }
}