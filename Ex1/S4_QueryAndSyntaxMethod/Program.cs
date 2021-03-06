﻿using System;
using System.Linq;
using System.Collections.Generic;
using QueryAndMethodSyntax;

namespace S4_QueryAndSyntaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };
            #region Using LinQ Syntax
            //var result = from s in stringList
            //             where s.Contains("Tutorials")
            //             select s;
            #endregion

            #region Using LamdaExpression
            var result = stringList.Where(s => s.Contains("Tutorials"));
            #endregion

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var teenAgerStudents = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select s;

            //var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20);

            foreach (var s in teenAgerStudents)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.ReadKey();
        }
    }
}
