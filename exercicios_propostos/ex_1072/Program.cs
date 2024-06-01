using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1072
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, X, numIn, numOut;
            X = numIn = numOut = 0;  

            N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    numIn++;
                }
                else
                {
                   numOut++;
                 
                }
            }
            Console.WriteLine($"{numIn} in");
            Console.WriteLine($"{numOut} out");
            
        }
    }
}
