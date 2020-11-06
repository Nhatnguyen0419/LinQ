using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace S6_FillteringOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 18} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            #region Cách 1
            //var fillterResult = from s in studentList
            //                    where s.Age > 12 && s.Age < 20
            //                    select s.StudentName;
            #endregion

            #region Cách 2
            //IEnumerable<string> fillterResult = from s in studentList
            //                                    where s.Age > 12
            //                                    where s.Age < 20
            //                                    select s.StudentName;
            #endregion

            #region Cách 3
            var fillterResult = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20);
            #endregion

            //OfType
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;
            foreach (var s in stringResult)
            {
                Console.WriteLine(s);

            }

            var inResult = from s in mixedList.OfType<int>()
                           select s;

            foreach (var s in inResult)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
