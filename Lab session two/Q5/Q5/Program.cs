using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 integers:");
            int[] array= new int[10];
            for(int j = 0; j < 10; j++)
            {
                array[j] = int.Parse(Console.ReadLine());

            }
            for(int i=0; i < 10; i++)
            {                
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"{array[i]} is a even number!");
                }
                else
                {
                    Console.WriteLine($"{array[i]} is an odd number!");
                }
                
            }
            Console.ReadLine();

        }
    }
}
