using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Student
    {
        //Properties
        private string Name;
        private int Age;
        private string Major;

        //Constructor
        public Student(string name, int age, string major)
        {
            Name = name;
            Age = age;
            Major = major;
        }

        //Method to introduce the student.
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}. I'm {Age} years old and my major subject is {Major}");
        }
    }
}
