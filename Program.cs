using System;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");
            
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979, 02, 26),
                EmployeeType.Manager, 25);

            Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 10, 05),
                EmployeeType.Research, 30);

            ////understanding how values passed by reference in an obj
            // Employee testEmployee = bethany;
            ////I created a new variable, that apoint to the same employee, the same obj in the memory!
            //// So there are 2 employee references that point to the same object
            // testEmployee.firstName = "Gill";
            // bethany.DisplayEmployeeDetais();
            ////-----------------------------------

            bethany.DisplayEmployeeDetais();
            bethany.PerfomWork();
            bethany.PerfomWork();
            bethany.PerfomWork();
            bethany.ReceiveWage();

            Console.WriteLine("\n\nCreating an employee");
            Console.WriteLine("--------------------\n");

            george.DisplayEmployeeDetais();
            george.PerfomWork();
            george.PerfomWork();
            george.PerfomWork();
            george.ReceiveWage();

            Console.ReadLine();
        }
    }
}