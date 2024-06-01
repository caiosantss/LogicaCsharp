using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
              do vetor (supor não haver empates). Mostrar também a posição do maior elemento.*/

            int N, indiceMaiorNumero; 
            double maiorNumero;           
            N = int.Parse(Console.ReadLine());
            double [] numeros = new double[N];

            for (int i = 0; i < N; i++)
            {
                
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            maiorNumero = 0.0;
            indiceMaiorNumero = 0;
            for(int j = 0; j < N; j++)  
            {
                if (numeros[j] > maiorNumero)
                {
                    maiorNumero = numeros[j];
                    indiceMaiorNumero = j;

                }
            }
            
            Console.WriteLine($"O maior numero digitado foi: {maiorNumero.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A posição do maior numero é: {indiceMaiorNumero + 1}");

            Console.ReadLine();
        }
    }
}
