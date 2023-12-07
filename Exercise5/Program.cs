namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instance of Student 
            Student john = new Student("John Doe", 20, "Computer Science");

            //Calling the Introduce method
            john.Introduce();
        }
    }
}