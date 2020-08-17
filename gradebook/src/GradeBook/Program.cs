﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gaurav's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");

            // var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            // grades.Add(56.1);

            // var result = 0.0;
            // var highGrade = double.MinValue;
            // var lowGrade = double.MaxValue;

            // foreach(var number in grades)
            // {
            //     lowGrade = Math.Min(number, lowGrade);
            //     highGrade = Math.Max(number, highGrade);
            //     result += number;
            // }
            // result /= grades.Count;
            // System.Console.WriteLine($"The lowest grade is {lowGrade}");
            // System.Console.WriteLine($"The highest grade is {highGrade}");
            // Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}