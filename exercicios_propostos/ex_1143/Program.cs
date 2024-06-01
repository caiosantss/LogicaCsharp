using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, quadrado, cubo;           
            N = int.Parse(Console.ReadLine());

            if (N > 1 && N < 1000)
            {            
                for (int i = 1; i <= N; i++)
                {
                    quadrado = (int)Math.Pow(i, 2);
                    cubo = (int)Math.Pow(i, 3);
                    Console.WriteLine($"{i} {quadrado} {cubo}");
                }
            }
            Console.ReadLine();
        }
    }
}
