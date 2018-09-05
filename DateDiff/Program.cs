using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        //'get' function calls back DateTimeStyle used in this program, 'private set' is needed to be more restricitive than the 1st method
        public static object DateTimeStyle { get; private set; }
        //Declares Main class and entry point for the code, 'void' means will not call back once run, 'string...' are the parameters
        static void Main(string[] args)
        {
            Dates();
            Console.ReadLine();

        }

        public static void Dates()
        {
            //Begin the actual code
            Console.WriteLine("Enter any date (Month, Day, Year): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter another date(Month, Day, Year): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            // an 'else if' statement to always return the value as positive
            if (firstDate < secondDate)
            {
                TimeSpan diff = secondDate - firstDate;
                //the code's answer and output displayed on the console
                Console.WriteLine("Days : " + diff.TotalDays.ToString());
                Console.WriteLine("Hours : " + diff.TotalHours.ToString());
                Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());
            }

            else if (secondDate < firstDate)
            {
                TimeSpan diff = firstDate - secondDate;


                //the code's answer and output displayed on the console
                Console.WriteLine("The difference in days : " + diff.TotalDays.ToString());
                Console.WriteLine("The difference in hours : " + diff.TotalHours.ToString());
                Console.WriteLine("The difference in minutes : " + diff.TotalMinutes.ToString());


            }
        }
    }
}


