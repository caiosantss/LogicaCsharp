using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1131
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int  GolInter, GolGremio, continuar, vitoriaInter, vitoriaGremio, empates ,total;
            total = empates = vitoriaGremio = vitoriaInter = 0;
            string[] grenais;         
            continuar = 1;

                while (continuar == 1)
                {
                    
                    grenais = Console.ReadLine().Split(' ');
                    GolInter = int.Parse(grenais[0]);
                    GolGremio = int.Parse(grenais[1]);

                    if (GolInter > GolGremio)
                    {
                        vitoriaInter++;
                    }
                    else if (GolInter == GolGremio)
                    {
                        empates++;
                    }
                    else
                    {
                        vitoriaGremio++;
                    }
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    continuar = int.Parse(Console.ReadLine());

                }
           total = vitoriaInter + vitoriaGremio + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empates);
            if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }else if (vitoriaInter == vitoriaGremio)
            {
                Console.WriteLine("Nao houve vencedor");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
            Console.ReadLine ();
        }
    }
}
