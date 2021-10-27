using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Fibonacci
    {

        public int Num;
        private int firstTerm = 0;
        private int secondTerm = 1;
        private int nextTerm;
        public void FibonacciSeries()
        {
            nextTerm = firstTerm + secondTerm;
            Console.WriteLine("Febonacci series first term is " + firstTerm);
            Console.WriteLine("Febonacci series second term is " + secondTerm);
            Console.WriteLine("Febonacci series thired term is " + nextTerm);

            for (int i = 4; i<= Num; i++)
            {
                firstTerm = secondTerm;
                secondTerm = nextTerm;
                nextTerm = firstTerm;
                Console.WriteLine("fibonacci series of : " + i + "Term is :" + nextTerm);
            }
        }
    }
}
