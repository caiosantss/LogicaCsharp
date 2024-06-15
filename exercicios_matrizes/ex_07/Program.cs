using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int linhas, colunas;
            Console.WriteLine("digite: 'LINHA COLUNA' ");
            string[] linhacoluna = Console.ReadLine().Split(' ');
            linhas = int.Parse(linhacoluna[0]);
            colunas = int.Parse(linhacoluna[1]);
            int [,] matrizA =  new int[linhas, colunas];
            int[,] matrizB = new int[linhas, colunas];
            int[,] matrizC = new int[linhas, colunas];


            Console.WriteLine($"Preencha a primeira matriz");
            for (int i = 0; i < linhas; i++)
            {
                string[] primeiraMatriz = Console.ReadLine().Split(' ');
                for (global::System.Int32 j = 0; j < colunas; j++)
                {
                    matrizA[i, j] = int.Parse(primeiraMatriz[j]);
                }
            }

            Console.WriteLine($"Preencha a SEGUNDA matriz");
            for (int i = 0; i < linhas; i++)
            {
                string[] segundaMatriz = Console.ReadLine().Split(' ');
                for (global::System.Int32 j = 0; j < colunas; j++)
                {
                    matrizB[i, j] = int.Parse(segundaMatriz[j]);
                }
            }

            Console.WriteLine("Matriz com a soma das posições correspondentes");
            int soma;
            soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                
                for (global::System.Int32 j = 0; j < colunas; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.Write($"{matrizC[i, j]} ");
                   
                }

                Console.WriteLine();
            }

            Console.ReadLine(); 
        }
    }
}
