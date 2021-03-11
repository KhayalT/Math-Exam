using System;

namespace FizzBaz
{
    public class Fizz
    {
        public string Test(int num)
        {
            string strg = "";

                if (num % 3 == 0)
                {
                    strg += "Fizz";
                }
                if (num % 5 == 0)
                {
                    strg += "Buzz";
                }
                if (num % 7 == 0)
                {
                    strg += "Bazz";
                }
                if (strg.Length == 0)
                {
                    strg = num.ToString();
                }
                Console.WriteLine(strg);
            
            return strg;

        }
    }
}
