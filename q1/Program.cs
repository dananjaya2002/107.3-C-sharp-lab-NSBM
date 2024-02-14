using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Course
    {
        private string courseName {  get; }
        private string instructorName;
        private double grade {  get; }

        public static void SetInstrucorName (string instructorName)
        {
            Console.WriteLine("Enter the Instructor's Name:");
            string name = Console.ReadLine ();
            if (name == null)
            {
                Console.WriteLine("this is a null value");
            }
            else
            {
                instructorName = name;
            }

        }

        private static string CalculateLetterGrade(double grade)
        {
            string letter;
            
            if (grade >= 0 && grade < 35.0)
            {
                letter = "F";
            }
            else if (grade >= 35.0 && grade < 55.0)
            {
                letter = "S";
            }           
            else if (grade >= 55.0 && grade < 65.0)
            {
                letter = "C";
            }
            else if (grade >= 65.0 && grade < 75.0)
            {
                letter = "B";
            }
            else if (grade >= 75.0 && grade <= 100.0)
            {
                letter = "A";
            }
            else
            {
                letter = "Invalid mark";
            }

            return letter;
        }

        public void PrintCourseInfo()
        {
            string gradeLetter = CalculateLetterGrade(grade);
            Console.WriteLine($"Course Name : {courseName} and Instrctor's Name : {instructorName} and Grade : {grade}");
        }

        
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        

    }
}
