using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;
            double n1, n2, n3, media, peso1, peso2, peso3;
            peso1 = 2.0;
            peso2 = 3.0;
            peso3 = 5.0;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                n1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);
                media = ((n1 * peso1) + (n2 * peso2) + (n3 * peso3)) / (peso1 + peso2 + peso3);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
