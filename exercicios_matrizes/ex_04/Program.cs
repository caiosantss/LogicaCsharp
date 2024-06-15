using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar na tela somente os números negativos da matriz.*/

            int linhas, colunas;
            Console.WriteLine("Digite o numero de linhas e colunas na mesma linhas 'linhas colunas': ");
            string[] dados = Console.ReadLine().Split(' ');
            linhas = int.Parse(dados[0]);
            colunas = int.Parse(dados[1]);
            int[,] matrizNumeros = new int[linhas, colunas];

            Console.WriteLine("Digite os elementos da matriz ");
            for (int i = 0; i < linhas; i++)
            {
                string[]numeros = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    matrizNumeros[i, j] = int.Parse(numeros[j]);
                }
            }

            int contadorNumeroNegativos = 0;


            Console.WriteLine($"Valores negativos: ");

            for (int i = 0; i < linhas; i++)
            {
                for (global::System.Int32 j = 0; j < colunas; j++)
                {
                    if (matrizNumeros[i, j] < 0)
                    {
                        Console.WriteLine($"{matrizNumeros[i,j]}");
                        contadorNumeroNegativos++;   
                    }
                }
            }
            Console.WriteLine($"Quantidade de numers negativos na matriz: {contadorNumeroNegativos}");
            Console.ReadLine();
        }
    }
}
