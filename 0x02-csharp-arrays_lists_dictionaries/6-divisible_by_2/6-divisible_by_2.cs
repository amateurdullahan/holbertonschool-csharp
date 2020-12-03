using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> tfList = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                tfList.Add(true);
            }
            else
            {
                tfList.Add(false);
            }
        }
        return tfList;
    }
}