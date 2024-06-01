using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.*/

            int N, contador, maiorValor;
            maiorValor = contador = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                N = int.Parse(Console.ReadLine());
               
                if (N > maiorValor)
                {
                    maiorValor = N;
                    contador = i;
                }
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(contador);
            Console.ReadLine();

        }
    }
}
