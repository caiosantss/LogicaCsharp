using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
                                Salário	Percentual de Reajuste
                                0 - 400.00           15%
                                400.01 - 800.00     12%
                                800.01 - 1200.00      10%
                                1200.01 - 2000.00     7%
                                Acima de 2000.00       4%
Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
             */

            double salario, percentualAumento, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 2000 )
            {
                percentualAumento = 0.04;
                reajuste = percentualAumento * salario;
                salario = reajuste + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentualAumento * 100) + " %");
            }
            else if (  salario <= 2000 && salario > 1200)
            {
                percentualAumento = 0.07;
                reajuste = percentualAumento * salario;
                salario = reajuste + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentualAumento * 100) + " %");
            }
            else if (salario <= 1200 && salario > 800)
            {
                percentualAumento = 0.1;
                reajuste = percentualAumento * salario;
                salario = reajuste + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentualAumento * 100) + " %");
            }
            else if (salario <= 800 && salario > 400)
            {
                percentualAumento = 0.12;
                reajuste = percentualAumento * salario;
                salario = reajuste + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentualAumento * 100) + " %");
            }
            else if (salario <= 400)
            {
                percentualAumento = 0.15;
                reajuste = percentualAumento * salario;
                salario = reajuste + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentualAumento * 100) + " %");
            }
            Console.ReadLine();        
        }
    }
}
