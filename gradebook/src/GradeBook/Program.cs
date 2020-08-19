using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gaurav's Grade Book");

            var done = false;

            while(!done)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    done = true;
                    continue;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            
            var stats = book.GetStatistics();

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
    }
}
