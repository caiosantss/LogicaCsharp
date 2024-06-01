using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1060
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3, n4, n5, n6;
            n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] numeros = new double[6];
            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;
            numeros[3] = n4;
            numeros[4] = n5;
            numeros[5] = n6;
            int contador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                
                if (numeros[i] > 0)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador + " valores positivos");

            Console.ReadLine();

        }
    }
}
