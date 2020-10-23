
using S2_ExtensionMethod.Extensions;
using System;
using System.Collections.Generic;

namespace S2_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "43.35";
            //double data = text.ToDouble();
            //Console.WriteLine(data);
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() { Id = 1, Name = "A" },
                new Employee() { Id = 2, Name = "B" },
            };
            #region Without Extension Method
            //var enumerator = developers.GetEnumerator();
            //int count = 0;
            //while (enumerator.MoveNext())
            //{
            //    count++;
            //}
            #endregion

            #region With Extension Method
             var result = developers.Count();
            #endregion

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
