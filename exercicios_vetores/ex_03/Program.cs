using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string [] nomes;
            double[] alturas;
            int[] idades;
            string[] dadosCliente;

            N = int.Parse(Console.ReadLine());
             nomes = new string[N];
            alturas = new double[N];
            idades = new int[N];
            // Capta e atribui os dados do usuario
            for (int i = 0; i < N; i++)
            {
                dadosCliente = Console.ReadLine().Split(' ');
                nomes[i] = dadosCliente[0];
                idades[i] = int.Parse(dadosCliente[1]);
                alturas[i] = double.Parse(dadosCliente[2],CultureInfo.InvariantCulture);
            }

            double mediaAlturas;
            mediaAlturas = 0.0;
            double somaAlturas;
            somaAlturas = 0.0;
            //Calcular a media

            for (int i = 0; i < N; i++)
            {
                somaAlturas = somaAlturas + alturas[i];
               
            }

            mediaAlturas = somaAlturas / N;
            Console.WriteLine($"Altura media: {mediaAlturas.ToString("F2",CultureInfo.InvariantCulture)}");



            //Calcula % das idades menores de 16 anos 
            double porcentagemIdade16 = 0.0;
            double contador;
            contador = 0.0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    contador++;
                }
            }

            porcentagemIdade16 = (contador / N) * 100.0;
            Console.WriteLine($"Porcentagem pessoas com menos de 16 anos: {porcentagemIdade16.ToString("F2", CultureInfo.InvariantCulture)}%");

            Console.ReadLine();



        }
    }
}
