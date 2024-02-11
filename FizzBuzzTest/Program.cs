using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing FizzBuzz Result
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                string result = GetFizzBuzz(i);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        static string GetFizzBuzz(int n)
        {
            string result = n.ToString();
            if (n % 3 == 0)
            {
                result = "Fizz";
            }
            if (n % 5 == 0)
            {
                result = "Buzz";
            }
            if (n % 3 == 0 && n % 5 == 0)
            {
                result =  "FizzBuzz";
            }
           
            return result;    
        }
    }
}
