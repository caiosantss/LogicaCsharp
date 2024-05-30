using System;
using System.Globalization;

namespace ex_1036
{

    class Program
{

    static void Main(string[] args)
    {


            // A ! 0 
            // delta > 0

            double A, B, C, delta, Raiz1, Raiz2;
            string[] numeros = (Console.ReadLine().Split(' '));
            A = double.Parse(numeros[0],CultureInfo.InvariantCulture);
            B = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            C = double.Parse(numeros[2], CultureInfo.InvariantCulture);


            // Formula de Bhaskara; A não pode ser 0 e delta não pode ser negativo
            delta = (double)(Math.Pow(B, 2) - (4 * A * C));
            Raiz1 =(double) (-B + Math.Sqrt(delta)) / (2 * A) ;
            Raiz2 = (double)(-B - Math.Sqrt(delta)) / (2 * A);
             
            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + Raiz1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + Raiz2.ToString("F5",CultureInfo.InvariantCulture));
            }



        }

    }
}