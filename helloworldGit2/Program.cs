using System;
using System.Diagnostics;

namespace helloworldGit2
{
    class Program
    {
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

                int iterations = 10;
                for (int i = 0; i < iterations; i++)  // i++ = i+1
                {
                    Debug.WriteLine("this is iterations   " + i);
                }

               // return doublingTime;

            }




        }
    }
}
