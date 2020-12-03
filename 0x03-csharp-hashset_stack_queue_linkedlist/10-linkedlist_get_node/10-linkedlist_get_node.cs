using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var node = myLList.First;
        for (int i = 0; i < myLList.Count && node != null; i++, node = node.Next)
        {
            if (i == n)
            {
                return node.Value;
            }
        }
        return 0;
    }
}