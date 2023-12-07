using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
            Console.WriteLine($"Pushed: {item}");
            PrintStack();
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot pop because the stack is empty");
            }

            int lastIndex = items.Count - 1;
            T poppedItem = items[lastIndex];
            items.RemoveAt(lastIndex);

            Console.WriteLine($"Popped: {poppedItem}");
            PrintStack();

            return poppedItem;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot peek because the stack is empty");
            }

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        private void PrintStack()
        {
            Console.Write("Stack: ");
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }

}
