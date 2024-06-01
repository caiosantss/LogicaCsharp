using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.*/

            int X, Y, min, max;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            if (X > 0 && Y > 0)
            {
                if (X > Y)
                {
                    max = X;
                    min = Y;
                }
                else
                {
                    max = Y;
                    min = X;
                }
           
                for (int i = min; i < max; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
