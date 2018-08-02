using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEnumConsoleApp

//1. Create an enum for the days of the week.
//2. Prompt the user to enter the current day of the week.
//3. Assign the value to a variable of that enum data type you just created.
//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                Console.WriteLine("Welcome to the Enum Demonstration Application!");
                Console.WriteLine("I'll prompt you for the current day of the week and verify that it is a valid choice!");
                Console.WriteLine();
                Console.Write("What is the current day of the week? ");
                string UserInputDay = Convert.ToString(Console.ReadLine().ToUpper());
                
                DaysOfWeek daysOfWeek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), UserInputDay);

                Console.WriteLine("Good job! That was  a valid response, thank you for demoing my application!");
                Console.WriteLine("Press enter to exit!");
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine("Press enter to try again.");
                Console.ReadLine();
                goto Start;
            }



        }
            public enum DaysOfWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        
    }
}
