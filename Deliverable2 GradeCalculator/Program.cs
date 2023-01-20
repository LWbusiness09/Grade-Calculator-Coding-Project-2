/*
Author: Lucas Werneck
Date: 01/19/2023
Description: Deliverable 2. C# Console Application for calculating letter grades.
*/

using System;
namespace Deliverable2_GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade for the course is " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade for the course is " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade for the course is " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade for the course " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade for the course is " + letter);
                }
            }
            catch
            {
                Console.WriteLine("Please, enter an integer number");
            }


        }
    }
}
