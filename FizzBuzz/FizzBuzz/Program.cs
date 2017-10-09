using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the FizzBuzz Program");
            FizzBuzz(25);
            Console.Read();
        }

        static void FizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
