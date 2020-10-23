using System;
using System.Collections.Generic;
using System.Linq;

namespace S3_LamdaExpression
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
                new Employee() { Id = 1, Name = "Alex" },
                new Employee() { Id = 2, Name = "Henrry" },
            };

            #region Without LamdaExpresion
            //foreach (var employee in developers.Where(NameStarWithA))
            //{
            //    Console.WriteLine(employee.Name);
            //}
            //Console.ReadKey();
            #endregion

        }
        private static bool NameStarWithA(Employee employee)
        {
            return employee.Name.StartsWith("A");
        }
    }
}
