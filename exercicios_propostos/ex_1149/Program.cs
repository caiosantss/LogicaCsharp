using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.*/


            int A, N, minimo, maximo, soma;
            soma = 0;
            string[] numeros = Console.ReadLine().Split(' ');
            A = int.Parse(numeros[0]);
            N = int.Parse(numeros[1]);

            while (N <= 0)
            {
                N = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                soma = (soma) + (A + i);

               
            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}
