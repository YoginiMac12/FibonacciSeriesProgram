using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Fibonacci Number:");
            int n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();
            int a = 0;
            int b = 1;
            int c;
 
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();    
        }
    }
}
