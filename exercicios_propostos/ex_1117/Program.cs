using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1117
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.*/

            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0 || nota1 > 10 )
            {
                Console.WriteLine("nota invalida");

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while ( nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            }

            
            media = (nota1 + nota2) / 2;
           Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();


        }
    }
}
