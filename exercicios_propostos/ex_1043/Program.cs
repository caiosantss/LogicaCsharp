using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1043
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, perimetro, area;
            string[] medidas = Console.ReadLine().Split(' ');
            A = double.Parse(medidas[0], CultureInfo.InvariantCulture);
            B = double.Parse(medidas[1], CultureInfo.InvariantCulture);
            C = double.Parse(medidas[2], CultureInfo.InvariantCulture);

            //Condição de existencia de um triangulo 
            if (A < B + C  && B < A + C && C < B + A)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) / 2) * C;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));

            }
            Console.ReadLine();
        }
    }
}
