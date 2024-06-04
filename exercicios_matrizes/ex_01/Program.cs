using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ler e imprimir na tela uma matriz 

            int Linhas, Colunas;
            int[,] matriz;

            string[] linhacoluna = Console.ReadLine().Split(' ');   
            Linhas = int.Parse(linhacoluna[0]);
            Colunas = int.Parse(linhacoluna[1]);
            matriz = new int[Linhas, Colunas];


            // Preenchendo a matriz 
            for (int i = 0; i < Linhas; i++)
            {
                string[] vetor = Console.ReadLine().Split(' '); 

                for (int j = 0; j < Colunas; j++)
                {
                    //Para cada posição da linha ele preenche a posição correspondente da coluna

                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < Linhas; i++)
            {
                for (global::System.Int32 j = 0; j < Colunas; j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
