using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1145
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.
             
             (1 < X < 20) e (X < Y < 100000).
             */

            int X, Y;
            
            string[] numeros = Console.ReadLine().Split(' ');  
            X = int.Parse(numeros[0]);
            Y = int.Parse(numeros[1]);

            if ((1 <  X && X < 20) && (Y > X && Y < 100000))
            {
                for (int i = 1; i <= Y; i++)
                {
                    if (i == X || i % X == 0)
                    {
                        int quebraLinha = i;
                        Console.WriteLine(" " + quebraLinha );
                    }
                    else
                    {
                        int mesmaLinha = i;
                        Console.Write(" " + mesmaLinha );
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
