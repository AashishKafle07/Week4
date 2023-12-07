namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Stack<int> class
            Stack<int> intStack = new Stack<int>();

            // Perform various push and pop operations
            intStack.Push(5);
            intStack.Push(6);
            intStack.Push(7);

            int poppedItem = intStack.Pop();
            Console.WriteLine($"Top item without popping: {intStack.Peek()}");
            Console.WriteLine($"Is the stack empty? {intStack.IsEmpty()}");
        }
    }
}