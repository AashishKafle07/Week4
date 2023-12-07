namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Circle class with a radius of 5
            Circle myCircle = new Circle(5);

            // Call the CalculateArea method and print out the result
            float area = myCircle.CalculateArea();
            Console.WriteLine($"Area of the circle is {area}.");
        }
    }
}