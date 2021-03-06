﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S11_QuantifierOperators
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
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
            Student std = new Student() { StudentID = 3, StudentName = "Bill" };

            bool areAllStudentTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
            bool areAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
            var result = studentList.Contains(std,new StudentComparer());
            Console.WriteLine(areAllStudentTeenAger);
            Console.WriteLine(areAnyStudentTeenAger);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
