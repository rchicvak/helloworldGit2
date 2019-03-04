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

           




        }
    }
}
