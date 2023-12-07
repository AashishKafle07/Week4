using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Shape
    {
        // Virtual method to calculate area which returns 0 by default
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        // Properties
        private float Radius;

        // Constructor
        public Circle(float radius)
        {
            Radius = radius;
        }

        // Override CalculateArea method to calculate area of a circle
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
