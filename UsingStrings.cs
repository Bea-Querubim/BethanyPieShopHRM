    using System;
    using System.Text;

    namespace BethanyPieShopHRM
    {
        class Program
        {
            static void Main (string[] args)
            {
                string firstName = "Bethany";
                string lastName = "Smith";
                string fullName = firstName +" "+ lastName; //concatenated or
                string fullName2 = string.Concat(firstName, lastName); // concatenated too

                //method to formt string
                string employeeName = "Bethany";
                int age = 34;

                string greetingText1 = "Hello" + employeeName +", you are" + age +"Years";
                string greetingText2 = string.Format("Hello {0}, you are {1} years", employeeName, age); //more legible
                string greetingText3 = $"Hello {employeeName}, you are {age} years"; //Better

                //lower case  -- to use uppercase or another, just change the member type (after .)
                string empId = firstName.ToLower() + " " + lastName.Trim().ToLower();
                // .Trim() add a space before and after the string

                int length = empId.Length;

                if (fullName.Contains("beth") || fullName.Contains("Beth"))
                {
                    Console.WriteLine("It's Bethanny");
                }

                string substring = fullName.Substring(1, 3);
                Console.WriteLine("Caracters 2 or 4 of fullname are " + substring);

                string nameUsingInterpolation = $"{firstName}-{lastName}";

                string greeting = $"Hello, {firstName.ToLower()}";
                Console.WriteLine(greeting);


                //--------------------------------------
                string name1 = "Bethany";
                string name2 = "BETHANY";

                Console.WriteLine("Are both names equal?" + (name1 == name2) ); //uper case and lower case make the string differents
                Console.WriteLine("Is name equal to Nethany?" + (name1 =="Bethany") );

                //------------------------------------
                string lastname = " Smith";


                StringBuilder builder = new StringBuilder();

                builder.Append("Last name: ");
                builder.AppendLine(lastname);
                builder.Append("First name: ");
                builder.Append(firstName);

                string result = builder.ToString();
                Console.WriteLine(result);

                // --------------------- parse Converting

                Console.WriteLine("Enter the wage: ");
                string wage = Console.ReadLine();

                int wageValue;
                if (int.TryParse(wage, out wageValue))
                    Console.WriteLine("Parsing success: " + wageValue);
                else
                    Console.WriteLine("Parsing failed");

                string hireDateString = "12/12/2020";
                DateTime hireDate = DateTime.Parse(hireDateString);
                Console.WriteLine("Parsed date: " + hireDate);

                Console.ReadLine();
            }
        }
    }
