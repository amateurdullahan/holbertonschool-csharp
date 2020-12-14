using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> nl = new List<int>();
        int result = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result = list1[i] / list2[i];
                nl.Add(result);
            }
            catch (DivideByZeroException)
            {
                result = 0;
                Console.WriteLine("Cannot divide by zero");
                nl.Add(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                return nl;
            }
            result = 0;
        }
        return nl;
    }
}
