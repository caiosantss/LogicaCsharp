using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
            dos números pares lidos. */

            Console.WriteLine("Digite o tamanho da lista de numeros desejada: ");
            int N = int.Parse(Console.ReadLine());
            int[] vetorNumeros = new int[N];
            Console.WriteLine("Agora digite os numeros a seres inseridos na lista: ");
            string[] stringNumeros = Console.ReadLine().Split(' ');

            //Atribuindo numeros ao array correto]

            for (int i = 0; i < N; i++)
            {
                vetorNumeros[i] = int.Parse(stringNumeros[i]);
            }

            //Realizando a soma dos numeros:  

            double soma, media, somaPares, mediaPares, contagemPares;
            soma = media = somaPares = mediaPares = contagemPares = 0.0;
            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                soma += vetorNumeros[i];
                if (vetorNumeros[i] % 2 == 0)
                {
                    somaPares += vetorNumeros[i];
                    contagemPares++;
                }
            }
            media = soma / vetorNumeros.Length;
            mediaPares = somaPares / contagemPares;
            Console.WriteLine($"Media total:{media.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Media entre os numeros pares :{mediaPares.ToString("F2", CultureInfo.InvariantCulture)} ");

            Console.ReadLine();




        }
    }
}
