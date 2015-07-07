//Travis Kean - Lab day 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accumulation
            double deposit = 35;
            int years = 0;

            years = 1;
            Console.WriteLine("The amount of money the woman has after depositing for " + years + " year(s), without accounting for leap years, is $" + Math.Round((deposit * years * 365)));
            Console.WriteLine();

            years = 2;
            Console.WriteLine("The amount of money the woman has after depositing for " + years + " year(s), without accounting for leap years, is $" + Math.Round((deposit * years * 365)));
            Console.WriteLine();

            years = 5;
            Console.WriteLine("The amount of money the woman has after depositing for " + years + " year(s), without accounting for leap years, is $" + Math.Round((deposit * years * 365)));
            Console.WriteLine();

            years = 10;
            Console.WriteLine("The amount of money the woman has after depositing for " + years + " year(s), without accounting for leap years, is $" + Math.Round((deposit * years * 365)));
            Console.WriteLine();

            Console.Read();
            Console.Clear();


            //Land Cost Calculator
            try
            {
                bool success = false;
                int width = 0, length = 0, perimeter = 0, tempnum = 0;
                double area = 0, cost = 0;
                string tempString = "";

                while (!success)
                {

                    Console.WriteLine("Enter the width in yards of the land you wish to purchase");
                    tempString = Console.ReadLine();
                    success = int.TryParse(tempString, out tempnum);

                }
                width = tempnum;

                success = false;
                while (!success)
                {

                    Console.WriteLine("Enter the length in yards of the land you wish to purchase");
                    tempString = Console.ReadLine();
                    success = int.TryParse(tempString, out tempnum);

                }
                length = tempnum;

                area = length * width;
                perimeter = 2 * length + 2 * width;

                cost = 5 * area + .75 * perimeter;

                Console.WriteLine("The total cost of land with a length of " + length + " and a width of " + width + " is $" + cost);
                Console.ReadLine();
                Console.Clear();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);


            }

            //Space Exploration
            double velocity = 10000, acceleration = .05;
            int seconds = 0, minutes = 0;

            minutes = 5;
            seconds = minutes * 60;

            velocity = velocity + (seconds / 2) * (1 + acceleration);

            Console.WriteLine("The velocity of the ship after 5 minutes of continous boosters is " + velocity);
            Console.WriteLine();

            velocity = 10000;
            minutes = 120;
            seconds = minutes * 60;

            while(minutes > 0)
            {
                velocity = velocity + (60 / 2 * 5) * (1 + acceleration);
                minutes = minutes - 15;
                
                //minutes = minutes - 5;
                //minutes = minutes - 10;


            }

            Console.WriteLine("The velocity of the ship after 2 hours of the set 5 minute booster \nthen 10 minute break rhythm is " + velocity);
            Console.ReadLine();
            Console.Clear();

            //Quadratic Formula
            // X = (-b +/- Sqrt(b^2 - 4ac)) / 2a

            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
            string aString = "", bString = "", cString = "";

            Console.WriteLine("The format of a quadratic equation is \"aX^2 + bX + c\".");
            Console.WriteLine("Enter the value for A");
            aString = Console.ReadLine();

            Console.WriteLine("Enter the value for B");
            bString = Console.ReadLine();

            Console.WriteLine("Enter the value for C");
            cString = Console.ReadLine();

            a = int.Parse(aString);
            b = int.Parse(bString);
            c = int.Parse(cString);

            bool checkX1 = false;
            bool checkX2 = false;
            int checknum = 0;

            try
            {
                x1 = (-b + Math.Sqrt(b * b - (4 * a * c)))/ (2 * a);
                x2 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

                checkX1 = int.TryParse(x1.ToString(), out checknum);
                checkX2 = int.TryParse(x2.ToString(), out checknum);

                if (checkX1 && checkX2)
                    Console.WriteLine("The two values for x are " + x1 + ", and " + x2);
                else if (checkX1 && !checkX2)
                    Console.WriteLine("there is only one solution, and it is x = " + x1);
                else if (checkX2 && !checkX2)
                    Console.WriteLine("there is only one solution, and it is x = " + x2);
                else
                    Console.WriteLine("The equation has no solution");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
