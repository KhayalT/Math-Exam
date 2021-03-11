using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100 ; i++)
            {
                FizzBaz.Fizz fizz = new FizzBaz.Fizz();
                Console.WriteLine(fizz.Test(i));
            }
        }
    }

}
