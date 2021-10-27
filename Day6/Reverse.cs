using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Reverse
    {
        public int Num, rev;
        public void ReverseNo()
        {
            while (Num > 0)
            {
                rev = (rev * 10) + (Num % 10);
                Num = Num / 10;
            }
            Console.WriteLine("Reverse of given number is: " + rev);
        }
    }
}
