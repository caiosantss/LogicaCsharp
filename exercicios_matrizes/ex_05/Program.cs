using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int OrdemQuadrada = int.Parse(Console.ReadLine());
            int[,] matrizQuadrada = new int[OrdemQuadrada, OrdemQuadrada];

            for (int i = 0; i < OrdemQuadrada; i++)
            {
                string[] PreenchendoMatriz = Console.ReadLine().Split(' '); 
                 for (global::System.Int32 j = 0; j < OrdemQuadrada; j++)
                {
                    matrizQuadrada[i, j] = int.Parse(PreenchendoMatriz[j]);
                }
            }

            int maiorNumero;
            

            for (int i = 0; i < OrdemQuadrada; i++)
            {
                maiorNumero = 0;

                for (global::System.Int32 j = 0; j < OrdemQuadrada; j++)
                {
                    if (matrizQuadrada[i, j] > maiorNumero)
                    {
                        maiorNumero = matrizQuadrada[i, j];
                    }                  
                }

                Console.WriteLine($"Maior numero da linha {i + 1}: {maiorNumero}");
            }
            Console.ReadLine(); 
        }
    }
}
