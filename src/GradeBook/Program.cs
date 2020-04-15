﻿using System;
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
                    System.Console.WriteLine("**");
                }                     
            }                

            var statistics = book.ShowStatistics();            

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The average grade is {statistics.Average:N2}"); // N2 = dua nol dibelakang koma
            System.Console.WriteLine($"The highest grade is {statistics.High}");
            System.Console.WriteLine($"The lowest grade is {statistics.Low}");
            System.Console.WriteLine($"The letter grade is {statistics.Letter}");
        }
    }
}
