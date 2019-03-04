using System;
using System.Diagnostics;

namespace helloworldGit2
{
    class Program
    {
        private static decimal income;
        private static decimal taxRate;
        private static decimal taxLiability;

        static void Main(string[] args)
        {
            Debug.WriteLine("Hello World!");
            Console.WriteLine("Hello, please enter you age as number....  ");
            string userInput = Console.ReadLine();
            Debug.WriteLine(userInput);

            // setup variable
            int age = 0;
            // try - catch block
            try    // use on line where there is error 
            {
                age = Convert.ToInt32(userInput);    // already converted to int
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            Debug.WriteLine(age);
            // add comment 2

            Console.WriteLine("Please enter the interest rate as 0.0X.....   ");
            string userNum = Console.ReadLine();
            Debug.WriteLine("The number you entered is ...." + userNum);
            decimal decNum = Convert.ToDecimal(userNum);
            Debug.WriteLine("The decimal you entered is  .....  " + decNum);

            //static double DoubledIn(double r)
            {
                double rate = 0.08;
                //double rate = decNum;   //issue with variable
                double doublingTime = Math.Log(2) / Math.Log(1 + rate);
                Debug.WriteLine("Doubling Time is " + doublingTime + "  years");

                // For Loop, continue for number of iterations
                int iterations = 10;
                for (int i = 0; i < iterations; i++)  // i++ = i+1
                {
                    Debug.WriteLine("this is iterations   " + i);
                }

               // return doublingTime;


                // Conditional loop
            }

            bool stopProgram = false;
            while (stopProgram == false)
            {
                Console.Write("Please enter your income in $, or -1 to stop, no decimals or commas....  ");
                income = Convert.ToDecimal(Console.ReadLine());
                if (income > 400000)
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }
                else if (income >= 0)
                {
                    taxLiability = 0;
                }
                else
                {
                    stopProgram = true;
                }

                Console.WriteLine("Tax Liability is ... " + taxLiability);

            }   // end while loop


        }
    }
}
