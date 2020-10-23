using System;
using System.Collections.Generic;
using System.Text;

namespace S2_ExtensionMethod.Extensions
{
    public static class MyLinq
    {
        //this is extension method use IEnumerable
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }

            return count;
        }
    }
}
