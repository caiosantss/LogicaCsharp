using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos ACIMA da diagonal principal*/

            int ordem;
            Console.WriteLine("Ordem da matriz:");
            ordem = int.Parse(Console.ReadLine());
            int[,] matriz = new int[ordem, ordem];
            Console.WriteLine("Elementos da matriz:");
            for (int i = 0; i < ordem; i++)
            {
                string[]numeros = Console.ReadLine().Split(' ');    

                for (int j = 0; j < ordem; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }


            Console.WriteLine("Soma dos elemetos acima da diagonal principal: ");
            int soma;
            soma = 0;           
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    if (j > i)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            Console.WriteLine($"{soma}");
            Console.ReadLine();
        }
    }
}
