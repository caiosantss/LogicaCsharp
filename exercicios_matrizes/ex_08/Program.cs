using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
            a) calcular e imprimir a soma de todos os elementos positivos da matriz.
            b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            d) imprimir os elementos da diagonal principal da matriz.
            e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
            */

            int N;
            string[] numeros;
            Console.WriteLine("Insira a ordem da matriz quadrada: ");
            N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];

            // Colocando os elementos na matriz

            Console.WriteLine("Preencha a matriz:");
            for (int i = 0; i < N; i++)
            {
                 numeros = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(numeros[j], CultureInfo.InvariantCulture);
                }
            }
            // A: calcular e imprimir a soma de todos os elementos positivos da matriz.

            double soma;
            soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0;  j < N;  j++)
                {
                    if (matriz[i,j] > 0)
                    {
                        soma += matriz[i,j];
                    }
                }
            }
            Console.WriteLine($"Soma de todos os elementos positivos: {soma.ToString("F2", CultureInfo.InvariantCulture)}");

            //b: fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.

            Console.WriteLine("Digite a linha em que deseja que seja impressa na tela: ");
            int linhaUsuario;
            linhaUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Linha {linhaUsuario}: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == linhaUsuario - 1)
                    {
                        Console.Write($"{matriz[i, j].ToString("F2", CultureInfo.InvariantCulture)} ");
                    }
                }
            }
            Console.WriteLine();
            // c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
           
            Console.WriteLine("Digite a coluna em que deseja que seja impressa na tela: ");
            int colunaUsuario;
            colunaUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Coluna {colunaUsuario}: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == colunaUsuario - 1)
                    {
                        Console.Write($"{matriz[i, j].ToString("f2", CultureInfo.InvariantCulture)} ");
                    }
                }
            }
            Console.WriteLine();

            // d) imprimir os elementos da diagonal principal da matriz.

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < N; i++){
                Console.Write($"{matriz[i, i].ToString("f2", CultureInfo.InvariantCulture)} ");
            }

            Console.WriteLine() ;

            //  e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.

            Console.WriteLine("Matriz alterada: ");
            for (int i = 0; i < N; i++)
            {
                for (global::System.Int32 j = 0; j <  N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2);
                    }
                    Console.Write($"{matriz[i, j].ToString("f2", CultureInfo.InvariantCulture)} ");
                }
                Console.WriteLine() ;
            }

            Console.ReadLine();
        }
    }
}
