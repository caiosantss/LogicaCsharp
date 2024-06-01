using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.*/

            uint opcao, alcool, gasolina, diesel;
            alcool = 0;
            gasolina = 0;
            diesel = 0;
            opcao = uint.Parse(Console.ReadLine());

            while (opcao != 4)
            {
                opcao = uint.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    alcool++;
                }
                else if (opcao == 2)
                {
                    gasolina++;
                }
                else if (opcao == 3)
                {
                    diesel++;
                }
               
            }
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine($"Alcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {diesel}");
                Console.ReadLine();
        }        
    }
}
