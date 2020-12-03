using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        IEnumerable<int> unq = myList.Distinct();
        int max = 0;
        foreach (int num in unq)
        {
            max += num;
        }
        return max;
    }
}