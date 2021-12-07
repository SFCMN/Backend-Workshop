using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCSharp.Advance1
{
    public static class ListExtension
    {
        public static List<string> ExtendedUnique(this List<string> list)
        {
            var hashSet = new HashSet<string>();
            foreach (var ele in list)
            {
                hashSet.Add(ele);
            }

            return hashSet.ToList();
        }
    }
}
