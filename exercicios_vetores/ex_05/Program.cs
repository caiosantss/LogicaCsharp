using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
            - todos os números pares
            - a quantidade de números pares*/

            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            string[] vetor = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                
                numeros[i] = int.Parse(vetor[i]);
            }

            int contador;
            contador = 0;

            foreach (int item in numeros)
            {
            

                if (item % 2 != 0)
                {
                    Console.Write($" {item}, ");
                    contador++;
                }        
            }

            Console.WriteLine($"Quantidade de numeros impares: {contador}");
            Console.ReadLine();
        }
    }
}
