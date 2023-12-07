namespace Exercise8
{
    using System;

    // Define the Point2D struct
    public struct Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    // Another class with the CalculateDistance method
    public class PointHelper
    {
        // Method to calculate the Euclidean distance between two Point2D objects
        public static float CalculateDistance(Point2D point1, Point2D point2)
        {
            float deltaX = point2.X - point1.X;
            float deltaY = point2.Y - point1.Y;

            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two instances of the Point2D struct
            Point2D pointA = new Point2D { X = 5.0f, Y = 3.0f };
            Point2D pointB = new Point2D { X = 10.0f, Y = 7.0f };

            // Calculate the distance between the two points
            float distance = PointHelper.CalculateDistance(pointA, pointB);

            // Print out the result
            Console.WriteLine($"Distance between the points is {distance}");
        }
    }
}