using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar 
                um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um 
                programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram: 
                 lucro< 10% 
                 10% ≤ lucro ≤ 20% 
                 lucro> 20% 
                Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o 
                lucro total.*/

            int NumeroMercadorias = int.Parse(Console.ReadLine());
            string[] nomeMercadoria = new string[NumeroMercadorias];
            double[] valorCompra = new double[NumeroMercadorias];
            double[] valorVenda = new double[NumeroMercadorias];

            // Atribuindo valor as variaveis

            for (int i = 0; i < NumeroMercadorias; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                nomeMercadoria[i] = vetor[0];
                valorCompra[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                valorVenda[i] = double.Parse(vetor[2],CultureInfo.InvariantCulture);
            }

            // Realizando valor total de compra / valor total de venda / valor total de lucro

            double somaCompra, lucro, somaVenda;
            somaCompra = lucro = somaVenda = 0.0;

            for (int i = 0; i < NumeroMercadorias; i++)
            {
                somaCompra += valorCompra[i];
                somaVenda += valorVenda[i];
        
            }

            lucro = somaVenda - somaCompra;

            Console.WriteLine($"Valor total de compra: {somaCompra.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda : {somaVenda.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total : {lucro.ToString("f2", CultureInfo.InvariantCulture)}");

            //lucro< 10%  == lucro < valorcompra[i] . 0.1
            // 10 % ≤ lucro ≤ 20 %
            //lucro > 20 %

            int lucroMenor10, lucro10e20, lucromais20;

            lucroMenor10 = lucro10e20 = lucromais20 = 0;

            for (int i = 0; i < NumeroMercadorias; i++)
            {
                lucro = valorVenda[i] - valorCompra[i];

                if (lucro < valorCompra[i] * 0.1)
                {
                    lucroMenor10++;
                }
                else if (lucro >= valorCompra[i] * 0.1 && lucro < valorCompra[i] * 0.2)
                {
                    lucro10e20++;
                }
                else
                {
                    lucromais20++;
                }
            }

            Console.WriteLine($"Lucros abaixo de 10%: {lucroMenor10}");
            Console.WriteLine($"Lucros entre 10% e 20%: {lucro10e20}");
            Console.WriteLine($"Lucros acima de 20%: {lucromais20}");

            Console.ReadLine();


        }
    }
}
