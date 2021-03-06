﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace S5_CustomFilterOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var teenAgerStudents = studentList.Fillter(s => s.Age > 12 && s.Age < 20);

            foreach (var s in teenAgerStudents)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.ReadKey();
        }
    }
}
