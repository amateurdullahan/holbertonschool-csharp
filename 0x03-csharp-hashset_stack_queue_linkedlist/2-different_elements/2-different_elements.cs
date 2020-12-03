using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> nlist = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            if (list2.Contains(list1[i]) == false)
            {
                nlist.Add(list1[i]);
            }
        }
        for (int i = 0; i < list2.Count; i++)
        {
            if (list1.Contains(list2[i]) == false)
            {
                nlist.Add(list2[i]);
            }
        }
        nlist.Sort();
        return nlist;
    }
}
