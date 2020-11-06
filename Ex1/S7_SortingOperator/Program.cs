using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S7_SortingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
            //query
            //var orderedbyResult = from s in studentList
            //                      orderby s.StudentName ascending, s.Age descending
            //                      select s;
            var orderedbyResult = studentList.OrderByDescending(s => s.StudentName).ThenBy(s => s.Age);
            foreach (var s in orderedbyResult)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.ReadKey();
        }
    }
}
