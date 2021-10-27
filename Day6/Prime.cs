using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Prime
    {
        public int Num;
        public void PrimeNo()
        {
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("Number " + Num + " is not a prime number");
                    break;
                }
                else 
                    Console.WriteLine("Number " + Num + " is a prime number");
                
                   
            }

        }

    }
}
