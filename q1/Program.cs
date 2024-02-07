using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    //create a Shape class    
    public class Shape
    {
        private double area;
        private string shapeType;

        //public property for shape type

        public string ShapeType { get { return shapeType; }  }

        public Shape(string shapeType)
        {
            this.shapeType = shapeType;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }
        
        

    }

    internal class Program
    {

        
        static void Main()
        {
           
            
        }

        
    }
}
