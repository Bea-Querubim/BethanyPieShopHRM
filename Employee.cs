using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthDay;

        private EmployeeType employeeType;

        public string FirstName
        {
            get{return firstName;} set { firstName = value;}
        }
        public string LastName
        {
            get {return lastName; }  set { lastName = value;}
        }
        public string Email
        {
            get { return email; }  set { email = value; }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked;}  set { numberOfHoursWorked = value; }
        }
        public double Wage
        { 
            get { return wage; } 
            set {
                if (wage < 0)
                    wage = 0;
                else
                    wage = value; 
            }
        }
        public double HourlyRate
        {
            get { return hourlyRate; } set { hourlyRate = value; }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        //creating constructor (Constructors are special types of methods used to create and initialize objects)
        public Employee(string first, string last, string em, DateTime bday, EmployeeType empType, double rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bday;
            EmployeeType = empType;
            HourlyRate = rate;
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
            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            Wage = NumberOfHoursWorked * HourlyRate;
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}");
            NumberOfHoursWorked = 0;
            
            return wage;
        }
        public void DisplayEmployeeDetais()
        {
           Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}" +
               $"\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}" +
               $"\nEmployee type: {EmployeeType}\n");
        }
    }
}
