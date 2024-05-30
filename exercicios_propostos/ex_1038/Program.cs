using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CodigoProduto, QuantidadeProduto;
            double ValorProduto, ValorConta;


            string[] Pedido = Console.ReadLine().Split(' ');
            CodigoProduto = int.Parse(Pedido[0]);
            QuantidadeProduto = int.Parse(Pedido[1]);

           switch (CodigoProduto)
            {
                case 1:
                    ValorProduto = 4.00;
                    ValorConta = (double)ValorProduto * QuantidadeProduto;
                    Console.WriteLine("Total: R$ " + ValorConta.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    ValorProduto = 4.50;
                    ValorConta = (double)ValorProduto * QuantidadeProduto;
                    Console.WriteLine("Total: R$ " + ValorConta.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    ValorProduto = 5.00;
                    ValorConta = (double)ValorProduto * QuantidadeProduto;
                    Console.WriteLine("Total: R$ " + ValorConta.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    ValorProduto = 2.00;
                    ValorConta = (double)ValorProduto * QuantidadeProduto;
                    Console.WriteLine("Total: R$ " + ValorConta.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    ValorProduto = 1.50;
                    ValorConta = (double)ValorProduto * QuantidadeProduto;
                    Console.WriteLine("Total: R$ " + ValorConta.ToString("F2",CultureInfo.InvariantCulture));
                    break;

                    

            }            
        }
    }
}
