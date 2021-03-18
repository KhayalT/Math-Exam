using System;

namespace FizzBaz
{
    public class Fizz
    {
        public string Test(int num)
        {
            string strg = "";
            string test = "";
            string convertedNum = Convert.ToString(num);
            for (int i = 0; i <= 100; i++)
            {
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
                    strg = num.ToString();
                }
                Console.WriteLine(strg);
            }
            if (num%3==0||convertedNum.Contains("3"))
            {
                test += "Fizz";
            }
            if (num%5==0||convertedNum.Contains("5"))
            {
                test += "Buzz";
            }
            return test;
        }
    }
}
//sən verilən X ədədinin fizz yoxsa buzz olmasını test eləmisən