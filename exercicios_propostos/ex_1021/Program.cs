using System;
using System.Globalization;

namespace ex_1021
{
    class Program
{

    static void Main(string[] args)
    {
            /*Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.*/

            double ValorTotal, moeda, resto;
            int nota, quociente;

            ValorTotal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");

            // Notas de 100
            nota = 100;
            quociente = (int) ValorTotal / nota;
            resto = (double)ValorTotal % nota;
            Console.WriteLine( quociente + " nota(s) de R$ " + nota + ".00");

            //notas de 50 
            nota = 50;
            quociente = (int) resto / nota; 
            resto =(double) resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            // notas de 20 
            nota = 20;
            quociente = (int)resto / nota;
            resto =(double) resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            // notas de 10 
            nota = 10;
            quociente = (int)resto / nota;
            resto =(double) resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            // notas de 5

            nota = 5;
            quociente = (int)resto / nota;
            resto =(double) resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            // notas de 2 

            nota = 2;
            quociente = (int)resto / nota;
            resto =(double) resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");


            Console.WriteLine("MOEDAS:");

            // moedas de 1 
            moeda = 1.00;
            quociente = (int)(resto / moeda);
            resto = (double)resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2",CultureInfo.InvariantCulture));

            // moedas de 0.50

            moeda = 0.50;
            quociente = (int)(resto / moeda);
            resto = (double)resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            // moedas de 0.25

            moeda = 0.25;
            quociente = (int)(resto / moeda);
            resto = (double)resto % moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            // moedas de 0.10

            moeda = 0.10;
            quociente = (int)(resto / moeda);
            resto = ((double)resto % moeda);
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            // moedas de 0.05

            moeda = 0.05;
            quociente = (int)(resto / moeda);
            resto = ((double)resto % moeda);
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

            // moedas de 0.01

            moeda = 0.01;
            quociente = (int)(resto / moeda);
            resto = ((double)resto % moeda);
            Console.WriteLine(quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}