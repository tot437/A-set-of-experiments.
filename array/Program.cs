using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nu = new int[5] {15,20,50,18,70};

            int[] nu2 = new int[5];
            nu2[0] = 10;
            nu2[1] = 20;
            nu2[2] = 30;
            nu2[3] = 40;
            nu2[4] = 50;

            for (int i=0; i<nu.Length; i++)
            {
                Console.WriteLine(nu[i] +" \n");

            }

            for (int j = 0; j < nu.Length; j++)
            {
                Console.WriteLine(nu2[j] + " \n");

            }


            
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
