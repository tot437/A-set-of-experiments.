using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condetions
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("enter your age: ");
            int age = Convert.ToInt16(Console.ReadLine());

            if (age>18) 
            {
                Console.WriteLine("True");
            }
            else if (age == 18)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("False");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j <= 5)
            {
                char[] f = null;
                Console.WriteLine("j= " + j);


                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("i= " + i); ;
                }
                j++;
            }


            Console.ReadLine();
            Console.ReadKey();

            

           
        }
    }
}
