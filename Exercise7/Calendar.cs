﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Calendar
    {
        // Nested enum type
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Method to print weekdays
        public void PrintWeekdays()
        {
            Console.WriteLine("Weekdays:");
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
