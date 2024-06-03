using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos
               elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.*/

            int N;
            double media, soma;
            Console.WriteLine("Digite quantos numeros terão o vetor: ");
            N = int.Parse(Console.ReadLine());
            double [] numerosReais = new double[N];

            //Digitando e atribuindo os valores aos vetores

            Console.WriteLine("Digite os numeros do vetor: ");
            string [] vetores = Console.ReadLine().Split(' ');  

            for (int i = 0; i < N; i++)
            {
                numerosReais[i] = double.Parse(vetores[i], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("");

            // Realizando a media dos numeros inseridos

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += numerosReais[i];
            }

            media =(double) soma / N;

            Console.WriteLine($"A media dos numeros inseridos: {media.ToString(CultureInfo.InvariantCulture)}");

            //Descobrindo os numeros que estão abaixo da media e os exibindo.

            Console.WriteLine("Numeros que estão abaixo da media: ");

            for (int i = 0; i < N; i++)
            {
                if (numerosReais[i] < media)
                {
                    Console.WriteLine(numerosReais[i].ToString(CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
