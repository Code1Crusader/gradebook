using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public List<double> grades ;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }


        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
             grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            result.Average = 0.0;
            var total = 0.0;
            foreach(double grade in this.grades)
            {
                total += grade;
                result.High = Math.Max(grade,result.High);
                result.Low= Math.Min(grade, result.Low);
                
            }
            result.Average = total/grades.Count;
            switch(result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result; 
        } 

    }
}