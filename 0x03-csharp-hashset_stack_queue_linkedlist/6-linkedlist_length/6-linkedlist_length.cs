using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int count  = 0;
        foreach (int item in myList)
        {
            count++;
        }
        return count;
    }
}
