using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Employee
    {
        private int EmployeeID;
        private string FullName;
        private double Salary;

        public Employee(int employeeID, string fullName, double salary)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            Salary = salary;
        }

        
        public int employeeID => EmployeeID;//read-only property for employeeID

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee's ID: {employeeID}");
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
