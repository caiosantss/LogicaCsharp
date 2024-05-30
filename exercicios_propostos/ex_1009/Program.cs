using System;
using System.Globalization;

namespace ex_1009
{
    class URI
    {

        static void Main(string[] args)
        {
            // Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

            string nomeVendedor;
            double salarioFixo, comissaoSobreVendas, TotalMes;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            comissaoSobreVendas = (double) 0.15 * totalVendas;

            TotalMes = salarioFixo + comissaoSobreVendas;

            Console.WriteLine("TOTAL = R$ " + TotalMes.ToString("F2", CultureInfo.InvariantCulture));
            

        }

    }
}
