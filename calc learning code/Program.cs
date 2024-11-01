using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = 16;
            var n2 = 18;
            var n3 = n1 + n2;
            var n4 = n1 - n2;
            var n5 = n1 * n2;
            var n6 = n1 / n2;

            var st = 1 != 2 && 3>2;
            var sv = 3 > 4 || 5>4;

            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(st);
            Console.WriteLine(sv);
            Console.ReadKey();
        }
    }
}
