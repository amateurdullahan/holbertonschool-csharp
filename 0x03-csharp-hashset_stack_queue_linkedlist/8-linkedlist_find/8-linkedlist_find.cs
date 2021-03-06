using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var node = myLList.First;
        for (int i = 0; node != null; i++, node = node.Next)
        {
            if (node.Value == value)
            {
                return i;
            }
        }
        return -1;
    }
}