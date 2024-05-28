using System;
using System.Globalization;


namespace ex_1005
{


    class Program
    {

     static void Main(string[] args)
        {

            double A, B, Media;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Media = ((A * 3.5) + (B * 7.5)) / 11;
           
            Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));
        }

    }
}