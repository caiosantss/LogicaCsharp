using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ler N numeros reais, armazena-los em um vetor. Em seguida imprimir todos os elementos do vetor, mostrar a soma e a media.

            int N;
            double soma, media;
            soma = 0.0;
            double[] numeros;
            N = int.Parse(Console.ReadLine());
            numeros = new double[N];
            string [] vetorNumeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(vetorNumeros[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                soma += numeros[i];
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + " = " + numeros[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            // Poderia usar-se um for para todo o código, porem para uma melhor manutenção e um código mais limpo recomenda-se atribuir uma responsabilidade para cada for, mesmo que o codigo fique um pouco mais longo.
           
            media = soma / numeros.Length;
            Console.WriteLine("Soma: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
