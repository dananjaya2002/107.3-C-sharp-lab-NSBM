using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public Course(string CourseName, double Grade)
        {
            courseName = CourseName;
            
            grade = Grade;
        }

        public void SetInstrucorName ()
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
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instrctor's Name: {instructorName}");
            Console.WriteLine($"Grade: {gradeLetter}");
        }

        
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            Course course1 = new Course("course1", 64.6);
            course1.SetInstrucorName();
            course1.PrintCourseInfo();



            Console.ReadLine();
        }

        

    }
}
