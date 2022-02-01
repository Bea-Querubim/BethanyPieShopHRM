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

            bethany.DisplayEmployeeDetais();
            bethany.PerfomWork();
            bethany.PerfomWork();
            bethany.PerfomWork();
            bethany.ReceiveWage();

            george.DisplayEmployeeDetais();
            george.PerfomWork();
            george.PerfomWork();
            george.PerfomWork();
            george.ReceiveWage();

            Console.ReadLine();
        }
    }
}