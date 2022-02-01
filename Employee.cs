using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public EmployeeType employeeType;

        //creating constructor (Constructors are special types of methods used to create and initialize objects)
        public Employee(string first, string last, string em, DateTime bday, EmployeeType empType, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bday;
            employeeType = empType;
            hourlyRate = rate;
        }

        public Employee(string first, string last, string em, DateTime bday, EmployeeType empType) : this (first, last, em, bday, empType, 0)
        {
            // call the upper constructor (contains 6 parameters) from this constructor (contains 5 parameters) using the key 'this' 
            // this constructor invokes the one above, passing the 5 parameters from above (with values that are in the variables) and the sixth parameter passes value 0
        }


        //creating methods
        public void PerfomWork()
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}");
            numberOfHoursWorked = 0;
            
            return wage;
        }
        public void DisplayEmployeeDetais()
        {
           Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}" +
               $"\nEmail: {email}\nBirthday: {birthDay.ToShortDateString()}" +
               $"\nEmployee type: {employeeType}\n");
        }
    }
}
