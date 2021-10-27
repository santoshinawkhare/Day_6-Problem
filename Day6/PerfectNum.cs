using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PerfectNum
    {
        public int Num;
        public int Sum = 0;
        public void PerfectNumfact()
        {
            for (int i = 1; i<=Num; i++)
            {
                if (Num % i == 0)
                {
                    Sum += i;
                    Console.WriteLine("Factor of Number is :" + i);
                }
            }
            Console.WriteLine("Sum of Factor is :" + Sum);

            if (Sum == Num)
            {
                Console.WriteLine("Number is not perfect number");
            }
            else
            {
                Console.WriteLine("Number is  perfect number");
            }
        }
    }
}
