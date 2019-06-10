using System;

namespace MathOperators
{
    class Program
    {
        private static double GetDoubleNumericValue(int attempts = 3, double valueIfParseFails = 0.0)
        {
            Console.Write("Enter any numeric value:  ");
            string temp = "";
            double dblNum = valueIfParseFails;
            int n = 0; //the number of times the user has entered unrecognized values
            bool validEntry = false; //used to repeat opportunities to enter valid data
            while (!validEntry & n < attempts)
            {
                temp = Console.ReadLine();
                validEntry = double.TryParse(temp, out dblNum);
                if (!validEntry)
                {
                    n++;
                    if (n < attempts)
                    {
                        Console.Write("Sorry, we had trouble recognizing that as a numeric value. Please try again:  ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, for demonstration purposes, we'll record that as the number {0}.", valueIfParseFails);
                        dblNum = valueIfParseFails; //set again because TryParse() converts "" to 0 even though it returns a false value
                    }
                }
            }
            return dblNum;
        }
        static void Main(string[] args)
        {
            double dblNum = 0;
            double dblNewNum = 0;

            //multiply user input by 50
            Console.Write("Enter any numeric value:  ");
            dblNum = GetDoubleNumericValue(3, 100);
            dblNewNum = dblNum * 50.0;
            Console.WriteLine("Your number is " + dblNum.ToString() + ". Your number multiplied by 50 = " + dblNewNum.ToString() + ".");

            //add 25 to user input
            Console.Write("Enter any numeric value:  ");
            dblNum = GetDoubleNumericValue(3, 100);
            dblNewNum = dblNum + 25.0;
            Console.WriteLine("Your number is " + dblNum.ToString() + ". Your number plus 25 = " + dblNewNum.ToString() + ".");

            //divides user input by 12.5
            Console.Write("Enter any numeric value:  ");
            dblNum = GetDoubleNumericValue(3, 100);
            dblNewNum = dblNum / 12.5;
            Console.WriteLine("Your number is " + dblNum.ToString() + ". Your number divided by 12.5 = " + dblNewNum.ToString() + ".");

            //checks if whether user input is greater than 50
            Console.Write("Enter any numeric value:  ");
            dblNum = GetDoubleNumericValue(3, 100);
            bool result = dblNum > 50;
            Console.WriteLine("Your number is " + dblNum.ToString() + ". The statement, your number is greater than 50 is " + result.ToString().ToLower() + ".");

            //returns the remainder after dividing the user input by 7
            Console.Write("Enter any numeric value:  ");
            dblNum = GetDoubleNumericValue(3, 100);
            dblNewNum = dblNum % 7;
            Console.WriteLine("Your number is " + dblNum.ToString() + ". The remainder after dividing your number by 7 is " + dblNewNum.ToString() + ".");
        }
    }
}
