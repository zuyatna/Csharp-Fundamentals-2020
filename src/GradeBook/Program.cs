using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            var book = new Book("Suyatna book");            

            while (true)
            {
                System.Console.WriteLine("Enter a grade or 'q' to quite");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }                

            var statistics = book.ShowStatistics();
            System.Console.WriteLine($"The average grade is {statistics.Average:N2}"); // N2 = dua nol dibelakang koma
            System.Console.WriteLine($"The highest grade is {statistics.High}");
            System.Console.WriteLine($"The lowest grade is {statistics.Low}");
            System.Console.WriteLine($"The letter grade is {statistics.Letter}");
        }
    }
}
