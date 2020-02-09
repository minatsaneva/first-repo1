using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
            int c;
            int n;
            while (a != 0)
            {
                a = a / 2;
                n = a % 2;
Console.Write(n);
            }

            Console.WriteLine();
            while (b != 0)
            {
                b = b / 2;
                c = b % 2;
                Console.Write(c);
            }
            Console.WriteLine();
            
             
        }
    }
}
