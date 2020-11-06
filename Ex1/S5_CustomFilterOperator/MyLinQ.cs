using System;
using System.Collections.Generic;
using System.Text;

namespace S5_CustomFilterOperator
{
    public static class MyLinQ
    {
        //1. Read only
        //2. Forward only
        public static IEnumerable<T> Fillter<T>(this IEnumerable<T> source, Func<T,bool> predicate)
        {
           // var result = new List<T>();
            foreach(var item in source)
            {
                if(predicate(item))
                {
                    //result.Add(item)
                    yield return item;
                }
            }
           // return result;
        }
    }
}
