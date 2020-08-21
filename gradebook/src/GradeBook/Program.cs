﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiscBook("Gaurav's Grade Book");
            book.GradeAdded += OnGradeAdded;

            var done = false;
            EnterGrades(book, done);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

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

        private static bool EnterGrades(IBook book, bool done)
        {
            while (!done)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("*");
                }
            }

            return done;
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
