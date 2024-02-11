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
            Console.WriteLine("Printing FizzBuzz Results");
            
            var fizzBuzzService = new FizzBuzzLogicService();
            var fizzBuzzPrinter = new FizzBuzzOutputService(fizzBuzzService);

            fizzBuzzPrinter.OutputFizzBuzz(1, 100);

            Console.WriteLine("----------End---------");

            Console.ReadLine();
        }
    }
}
