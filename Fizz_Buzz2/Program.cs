using System;
using FizzBuzz.Library;

namespace Fizz_Buzz
{
   public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
