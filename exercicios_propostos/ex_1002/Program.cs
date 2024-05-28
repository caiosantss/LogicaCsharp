using System;
using System.Globalization;

namespace ex_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, pi, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A="+area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
