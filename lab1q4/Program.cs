using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");

            string userinput = Console.ReadLine();

            if (int.TryParse(userinput, out int n))
            {
                PrintFibonacciSeries(n);
            }
            else
            {
                Console.WriteLine("ERROR:please enter valid integer.");
            }
        }  
        
        static void PrintFibonacciSeries(int n)
        {
            if (n<0)
            {
                Console.WriteLine("ERROR:please eneter a non-negative integer.");
            }
            int a = 0, b = 1;
            Console.WriteLine($"fibbonacci series (first {n} terms):{a} ,{b}");

           for (int i = 2; i<n; i++)
            {
                int nextTerm = a + b;
                Console.WriteLine($",{nextTerm}");

                a = b;
                b = nextTerm;

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
