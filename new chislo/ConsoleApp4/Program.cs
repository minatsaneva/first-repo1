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
            int n, m, m1, s = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            { m = int.Parse(Console.ReadLine());
                m1 = int.Parse(Console.ReadLine());
                s += m % m1;
            }
            Console.WriteLine(s);


        }
    }
}
