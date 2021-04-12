using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Class A");
            book.AddGrade(55.5);
            book.AddGrade(40.2);
            book.AddGrade(67.9);
            book.AddGrade(88.7);

            var command = "";
            var index = 1;
            

            var result = book.GetStatistics();

            Console.WriteLine($"The statistics of {book.Name} are:");
            Console.WriteLine($"The grade average is: {result.Average:N1}");
            Console.WriteLine($"The highest grade is: {result.High}");
            Console.WriteLine($"The lowest grade is: {result.Low}");
             
        }
    
    }

}
