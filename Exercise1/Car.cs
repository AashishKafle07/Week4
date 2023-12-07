using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Car
    {
        //Properties
        private string Brand;
        private int Year;
        private float Price;

        //Constructor
        public Car(string brand, int year, float price)
        {
            Brand = brand;
            Year = year;
            Price = price;
        }

        //Creating method that prints the details of car
        public void Output()
        {
            Console.WriteLine($"Brand of car is {Brand}, year of launch is {Year} and price is {Price}");
        }
    }
    
}
