using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2425SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MySwitch();
            Switcheroo();
            Console.ReadKey();
        }

        static void MySwitch()
        {
            Console.Write("Please enter a letter grade.");
            //char math_grade = char.Parse(Console.ReadLine());
            //char math_grade = Convert.ToChar(Console.ReadLine());
            char math_grade = Console.ReadLine()[0];

            switch (math_grade) { 
                case 'A':
                    Console.WriteLine("Hey. Good job getting an 'A'");
                    break;
                case 'B':
                    Console.WriteLine("You got a B");
                    break;
                case 'C':
                    Console.WriteLine("You got a C");
                    break;
                case 'D':
                    Console.WriteLine("You got a D");
                    break;
                case 'F':
                    Console.WriteLine("You got a For the love of god.");
                    break;
                default:
                    Console.WriteLine("Hmmm... Don't recognize the letter grade");
                    break;
            }
        }
        static void Switcheroo()
        {
            string dayOfWeek = "Friday";

            switch(dayOfWeek)
            {
                case "Sunday":
                case "Saturday":
                    Console.WriteLine("It's the weekend");
                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("It's a weekday. I'm not blinded by the light.");
                    break;
                default:
                    Console.WriteLine("Watchu talkin bout Willis.");
                    break;
            }
        }
    }
}
