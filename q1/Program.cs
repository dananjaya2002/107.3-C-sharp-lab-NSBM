using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    //create a student class    
    public class Student
    {
        //variable to store name
        public string name;
        //array to store 3 marks
        public int[] marks;

        public void StoreDetails(string StudentName, int[]stuMarks)
        {
            name = StudentName;
            marks = stuMarks;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");
            
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Marks: {marks[i]}");
            }
            Console.WriteLine("\n");
        }
    }

    internal class Program
    {

        
        static void Main()
        {
            //create an object
            Student student1 = new Student();
            Student student2 = new Student();

            //calling the StoreDetails method and store name and marks
            student1.StoreDetails("adam", new int[] { 88, 45, 89 });
            student2.StoreDetails("ginger", new int[] { 85, 48, 89 });

            //calling the DisplayDetails to show the added marks
            student1.DisplayDetails();
            student2.DisplayDetails();
            Console.ReadLine();
        }

        
    }
}
