using System;

namespace MathExam
{
    public class Math
    {
        public int Loop(int n)
        {
                int fizz = 0;
            for (int i = 1; i <= n; i++)
            {
                string strg = "";
                if (i % 3 == 0)
                {
                    strg += "Fizz";
                    fizz++;
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
                return fizz;
            }
        }
    }
}
