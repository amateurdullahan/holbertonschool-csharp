using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.Count == 0)
            return 0;
        int node = myLList.First.Value;
        myLList.RemoveFirst();
        return node;
    }
}
