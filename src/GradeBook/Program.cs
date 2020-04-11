using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            var book = new Book("Suyatna book");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            book.ShowStatistics();  

            var statistics = book.ShowStatistics();
            System.Console.WriteLine($"The average grade is {statistics.Average:N2}"); // N2 = dua nol dibelakang koma
            System.Console.WriteLine($"The highest grade is {statistics.High}");
            System.Console.WriteLine($"The lowest grade is {statistics.Low}");
        }
    }
}
