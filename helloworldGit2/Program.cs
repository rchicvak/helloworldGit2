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

                //--------------------

                // For Loop, continue for number of iterations
                int iterations = 10;
                  for (int i = 0;
                    i < iterations;
                        i++)  // i++ = i+1
                {
                    Debug.WriteLine("this is iterations   " + i);
                }

                //---------------------------------
                // Loop and If logic
                   iterations = 15;
                    for (int i = 1;
                         i <= iterations;
                         i++)
                {
                    if (i %2 == 0)
                    {
                        Debug.WriteLine(i / 2);
                    }
                    else
                    {
                        Debug.WriteLine(i * 2);
                    }
                    
                }
  
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

            //  Needed to create separate block otherwise creating method considers as large as block is, 
            //  Make only as small as you need.
            {
                Debug.WriteLine("this is the Second doubling problem");
                double rate1 = 0.04;    // note double is a data type  like integer
                double doublingTime1 = 0;
                //double doublingTime1;    no longer needed as included in method
                doublingTime1 = DoubledIn(rate1);   // references the method created below


                rate1 = 0.06;
                DoubledIn(rate1);  //  delete the method lines and add line for NewMethod(rate1)
                //doublingTime1 = Math.Log(2) / Math.Log(1 + rate1);
                //Debug.WriteLine("Doubling Time for rate  for " + rate1 + "  is " + doublingTime1 + "  years");
                doublingTime1 = DoubledIn(rate1);

                rate1 = 0.08;
                DoubledIn(rate1);
                //doublingTime1 = Math.Log(2) / Math.Log(1 + rate1);
                //Debug.WriteLine("Doubling Time for rate for  " + rate1 + "  is " + doublingTime1 + "  years");
                doublingTime1 = DoubledIn(rate1);


                for (double d = 0.02;   // start
                    d < 0.12;   // end
                    d = d + 0.01)  // increment
                {
                    doublingTime1 = DoubledIn(d);
                    Debug.WriteLine(doublingTime1);
                }
            }
        }

        private static double DoubledIn(double rate1)    // method signature  change from static to double
        {
            double doublingTime1 = Math.Log(2) / Math.Log(1 + rate1);
            Debug.WriteLine("Doubling Time for rate for " + rate1 + "  is " + doublingTime1 + "  years");

            return doublingTime1;
        }
    }
}
