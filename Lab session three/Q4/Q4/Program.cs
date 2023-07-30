using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Enter a number:");
            int num1=int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=1; i<=num1; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of all odd numbers from 1 to {num1} = {sum}");
            Console.ReadLine();
        }
    }
}
