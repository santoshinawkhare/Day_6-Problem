using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Day 6 program!");

            /* Fibonacci Ex1 = new Fibonacci();
             Console.WriteLine("Pls enter your Number");
             Ex1.Num = Convert.ToInt32(Console.ReadLine());
             Ex1.FibonacciSeries();*/

            PerfectNum Ex2 = new PerfectNum();
            Console.WriteLine("Pls enter your Number");
            Ex2.Num = Convert.ToInt32(Console.ReadLine());
            Ex2.PerfectNumfact();


            /* Prime Ex3 = new Prime();
             Console.WriteLine("Pls enter your Number");
             Ex3.Num = Convert.ToInt32(Console.ReadLine());
             Ex3.PrimeNo();*/

            /* Reverse Ex4 = new Reverse();
             Console.WriteLine("Pls enter your Number");
             Ex4.Num = Convert.ToInt32(Console.ReadLine());
             Ex4.ReverseNo();*/
        }
    }
}
