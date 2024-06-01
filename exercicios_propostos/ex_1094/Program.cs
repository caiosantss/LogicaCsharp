using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Quantia;
            
            char Coelho, Rato, Sapo, Bixo;
            double mediaCoelho, mediaSapo, mediaRato, quantiaCoelhos, quantiaRatos, quantiaSapos;
            quantiaCoelhos = quantiaRatos = quantiaSapos = 0.0;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] quantiaTipo = Console.ReadLine().Split(' ');
                Quantia = int.Parse(quantiaTipo[0]);
                Bixo = char.Parse(quantiaTipo[1]);
                if (Bixo == 'C')
                {
                    quantiaCoelhos += Quantia;
                    Coelho = Bixo;
                }
                else if (Bixo == 'R')
                {
                    quantiaRatos += Quantia;
                    Sapo = Bixo;
                }
                else
                {
                    quantiaSapos += Quantia;
                    Rato = Bixo;
                }
            }

            Quantia =(int)(quantiaCoelhos + quantiaSapos + quantiaRatos);
            mediaCoelho = (quantiaCoelhos / Quantia) * 100.0;
            mediaSapo = (quantiaSapos / Quantia) * 100.0;
            mediaRato = (quantiaRatos / Quantia) * 100.0;

            Console.WriteLine("Total: " + Quantia + " cobaias");
            Console.WriteLine("Total de coelhos: " + quantiaCoelhos);
            Console.WriteLine("Total de ratos: " + quantiaRatos);
            Console.WriteLine("Total de sapos: " + quantiaSapos);
            Console.WriteLine("Percentual de coelhos: " + mediaCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + mediaRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + mediaSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();

        }
    }
}
