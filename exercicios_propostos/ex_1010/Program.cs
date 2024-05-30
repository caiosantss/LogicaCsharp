using System;
using System.Globalization;


namespace ex_1010
{
    class URI
    {

        static void Main(string[] args)
        {

            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int numeroPecas1 = int.Parse(peca1[1]);
            double valorUnitarioPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);




            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int numeroPecas2 = int.Parse(peca2[1]);
            double valorUnitarioPeca2 = double.Parse(peca2[2],CultureInfo.InvariantCulture);


            double valorPagar = ((numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2));
            Console.WriteLine("VALOR A PAGAR: " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));




        }

    }
}