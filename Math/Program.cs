using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string strg = "";
                if (i % 3 == 0)
                {
                    strg += "Fizz";
                }
                if (i % 5 == 0)
                {
                    strg += "Buzz";
                }
                if (i % 7 == 0)
                {
                    strg += "Bazz";
                }
                if (strg.Length == 0)
                {
                    strg = i.ToString();
                }
                Console.WriteLine(strg);

            }
        }
    }
}
