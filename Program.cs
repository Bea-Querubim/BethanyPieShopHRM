using System;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            /* uderstanding methods  -- general
            *  <acess modifier>  <return type> Method_Name (Parameters)
            *  {
            *    method statements
            *  }
            */
            //int montlyWage = 1000;
            //int months = 12;

            //int yearlyWage = CalculateYearlyWage(montlyWage, months);

            //Console.WriteLine($"Yearly wage(from main): {yearlyWage}");

            //UsingValueParameters();
            //UsingRefParameters();
            //UsingOutParameters();
            UsingParams();

            Console.ReadLine(); 
        }

        public static int CalculateYearlyWage(int montlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {montlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12) //let's add a bonus month
                return montlyWage * (numberOfMonthsWorked + 1);

            return montlyWage * numberOfMonthsWorked;
        }

        public static void UsingValueParameters()
        {
            int montlyWage1 = 1000;
            int montlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWage(montlyWage1, months1, bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany):{yearlyWageForEmployee1}\n");


            int yearlyWageForEmployee2 = CalculateYearlyWage(montlyWage2, months2, bonus);
            Console.WriteLine($"Yearly wage for employee 2 (Jonh):{yearlyWageForEmployee2}");

        }

        public static int CalculateYearlyWage(int montlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (montlyWage < 2000)
                bonus *= 2;

            Console.WriteLine($"The early wage is: {montlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return montlyWage * numberOfMonthsWorked + bonus;
        }
    
        public static void UsingRefParameters()
        {
            int montlyWage1 = 1000;
            int montlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef (montlyWage1, months1, ref bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany):{yearlyWageForEmployee1ByRef}\n");


            int yearlyWageForEmployee2ByRef = CalculateYearlyWageByRef(montlyWage2, months2, ref bonus);
            Console.WriteLine($"Yearly wage for employee 2 (Jonh):{yearlyWageForEmployee2ByRef}");

        }

        public static int CalculateYearlyWageByRef(int montlyWage, int numberOfMonthsWorked, ref int bonus)
        {
            if (montlyWage < 2000)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled!! Yay!");
            }

            Console.WriteLine($"The early wage is: {montlyWage * numberOfMonthsWorked + bonus}");
            return montlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingOutParameters()
        {
            int montlyWage1 = 1234;
            int months1 = 12;
            int bonus; //no initial value has been set

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(montlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany):{yearlyWageForEmployee1}\n");
            Console.WriteLine($"Bethany received a  bonus of {bonus}");

        }

        public static int CalculateYearlyWageWithOut(int montlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000); //generate a random value smaller than 1000
  
            if (bonus < 500)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled!! Yay!");
            }

            Console.WriteLine($"The early wage is: {montlyWage * numberOfMonthsWorked + bonus}");
            return montlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingParams()
        {
            int monthlyWage1 = 1000, monthlyWage2 = 2500, monthlyWage3 = 1357, monthlyWage4 = 2468;

            int average = CalculateAverageMarge(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
            Console.WriteLine($"The average wage is {average}");
        }
        //private static int CalculateAverageMarge(int wage1, params int[] wages) // if we pass the variable before the parameter, it will be ignored {**wages1} 
        private static int CalculateAverageMarge( params int[] wages) // all parameters will be counted as passed in the function above
        {
            int total = 0;
            int numberOfWages = wages.Length;

            for(int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }
            return total / numberOfWages;
        }

    }
}