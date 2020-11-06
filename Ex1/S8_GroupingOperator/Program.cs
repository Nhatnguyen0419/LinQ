using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S8_GroupingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 15 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 18 }
            };
            //var grouptedResult = from s in studentList
            //                     group s by s.Age;

            // var grouptedResult = studentList.GroupBy(s => s.Age);

            var grouptedResult = studentList.ToLookup(s => s.Age); // thực thi dữ liệu trên memory

            foreach (var ageGroup in grouptedResult)
            {
                Console.WriteLine("Age: {0}",ageGroup.Key);
                foreach (var s in ageGroup)
                {
                    Console.WriteLine(s.StudentName);
                }
            }
            Console.ReadKey();

        }
    }
}
