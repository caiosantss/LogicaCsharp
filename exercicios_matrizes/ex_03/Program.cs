using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ler dois numeros inteiros M e N. Em seguida, ler uma matriz de M linhas e N colunas contendo números inteiros. Gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos da linha correspondente da matriz. Mostrar o vetor gerado. 

            int linhas, colunas;
            int[,] matriz;
            int[] vetor;
            Console.WriteLine("Digite o numero de LINHAS que a matriz tera: ");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de COLUNAS que a matriz tera: ");
            colunas = int.Parse(Console.ReadLine());    

            matriz = new int[linhas, colunas];
            vetor = new int[linhas];


            // PREENCHENDO A MATRIZ

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"Preencha a linha {i + 1} da matriz: ");

                string[] preencheMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(preencheMatriz[j]);
                }
            }

            // PREENCHENDO O VETOR COM A SOMA DE CADA LINHA DA MATRIZ

            int soma;
            
            for (int i = 0; i < linhas; i++)
            {
                soma = 0;

                for (int j = 0;  j < colunas; j++)
                {
                    soma += matriz[i, j];
                }

                vetor[i] = soma;

                Console.WriteLine($"Soma da linha {i + 1}: {vetor[i]}");
            }

            Console.ReadLine(); 
        }
    }
}
