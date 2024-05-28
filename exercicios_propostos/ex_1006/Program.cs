using System;
using System.Globalization;


namespace ex_1006 { 
    class Program
    {

        static void Main(string[] args)
        {
            // Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

            double A, B , C, Media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            A = A * 2;
            B = B * 3;
            C = C * 5;

            Media = (A + B + C) / 10;

            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));

        }

    }
}