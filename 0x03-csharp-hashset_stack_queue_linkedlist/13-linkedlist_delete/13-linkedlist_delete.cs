using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        var node = myLList.First;
        int cnt = 0;
        for (cnt = 0; cnt < index && cnt < myLList.Count; cnt++)
        {
            node = node.Next;
        }
        if (cnt == index)
        {
            myLList.Remove(node);
        }
    }
}

