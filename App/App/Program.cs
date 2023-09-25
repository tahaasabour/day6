
using System;
using System.Collections.Generic;
public delegate bool NumbersFilter(int number);

public class Program
{
  
    public static IEnumerable<int> FilterNumbersByCondition(IEnumerable<int> numbers
                                , NumbersFilter filter)
    {
        foreach (int number in numbers)
              if (filter(number))
                yield return number;
    }


    
    public static void Main()
    {
        List<int> numbers = new List<int>()
        {
            40, 899, 7, 9, 10, 77
        };
        // Lambda Expression
        // Goes To  =>

        foreach (int num in FilterNumbersByCondition(numbers, i => i > 10))
        {
            Console.WriteLine(num);
        } 

        Console.WriteLine();
        Console.WriteLine();

        foreach (int num in FilterNumbersByCondition(numbers, o => o %2 ==0))
            Console.WriteLine(num);
    }
}