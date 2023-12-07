using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Rectangle
    {
        //Properties
        private float Length;
        private float Width;

        //Constructor
        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        //Method to calcuate area
        public void CalculateArea()
        {
            float area=Length*Width;
            Console.WriteLine($"The area of rectangle having length {Length} and breadth {Width} is {area}");
        }
    }
}
