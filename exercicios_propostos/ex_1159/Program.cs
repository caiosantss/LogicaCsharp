using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando o valor de X for igual a 0). Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.*/


            int valorInicial, soma, ProximoPar, somaPar, somaImpar;
            valorInicial = int.Parse(Console.ReadLine());
            somaPar = 0;
            somaImpar = 0;

            while (valorInicial != 0)
            {
                if (valorInicial % 2 == 0)
                {

                    for (int i = 0; i <= 4; i++)
                    {
                        somaPar += valorInicial;
                        valorInicial += 2;
                                                
                    }

                    Console.WriteLine(somaPar);
                }            
                else if (valorInicial % 2 != 0)
                {                      
                    ProximoPar = valorInicial + 1;

                    for (int i = 0; i <= 4; i++)
                    {
                        somaImpar += ProximoPar;
                        ProximoPar += 2;
                       
                    }

                    Console.WriteLine($"{somaImpar}");
                }

                valorInicial = int.Parse(Console.ReadLine());
                somaPar = 0;
                somaImpar = 0;
            }
        }
    }
}
