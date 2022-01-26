using System;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicity types
            var montlyWage = 1234;
            var months = 12;
            var bonus = 1000;

            var isctive = true;
            var raiting = 99.25;

            double ratePerHour = 12.34;
            int numberOfHourWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHourWorked;
            Console.WriteLine(currentMonthWage);
            ratePerHour += 3; // improve rate per hour

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }
            int numberOfEmployees = 15;
            numberOfEmployees--;

            //understanding the members type  ( int.(ListOfMembers)  / char.(ListOfMembers)/ ...
            int intMaxValue = int.MaxValue;
            int intMinValue = Int32.MinValue;

            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            //understanding date type
            DateTime hireDate = new DateTime(2021, 06, 02/*<-days*/, 14,30, 0/*<-hours*/);
            Console.WriteLine(hireDate);

            DateTime exitDate = new DateTime(2021, 12, 11);
            // exemple invalid Date =>  DateTime invalidDate = new DateTime(2021, 15, 11);
            
            DateTime today = DateTime.Today;
            DateTime twoDaysLater = hireDate.AddDays(2);
            DayOfWeek day = hireDate.DayOfWeek;

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);  // sum between startTime + workTime

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(startHour.ToShortTimeString());

            Console.ReadLine();
        }
    }
}