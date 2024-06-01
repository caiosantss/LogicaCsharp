using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] numeros = Console.ReadLine().Split(' ');   
            x = int.Parse(numeros[0]);  
            y = int.Parse(numeros[1]);

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                numeros = Console.ReadLine().Split(' ');
                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);
            }
            
        }
    }
}
