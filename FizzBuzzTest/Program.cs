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

            
            var fizzBuzzService = new FizzBuzzLogicService();
            var fizzBuzzPrinter = new FizzBuzzOutputService(fizzBuzzService);

            fizzBuzzPrinter.OutputFizzBuzz(1, 100);

            Console.ReadLine();
        }

       /* static string GetFizzBuzz(int n)
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
        }*/
    }
}
