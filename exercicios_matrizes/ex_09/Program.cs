using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_09
{
    internal class Program
    {
        static void Main(string[] args)
        {/*O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de 
            soldados. Por exemplo, a figura abaixo mostra a organização do pelotão em 3 filas com 8 soldados em cada uma*/

            /*Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila", que consiste em dizer o número 
            de uma fila, de modo que os soldados desta fila devem se mover para a direita, e o último soldado da direita vai para a 
            posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila"*/

            int Mfilas, colunasSoldados;
            Console.WriteLine("Digite quantas filas de soldados terão: ");
            Mfilas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos soldados terão em cada fila: ");
            colunasSoldados = int.Parse(Console.ReadLine());
            int[,] matrizSoldados = new int[Mfilas, colunasSoldados];
            string[] identificadorSoldados;

            Console.WriteLine("Digite a indentificação de cada soldado: ");

            for (int i = 0; i < Mfilas; i++)
            {
                identificadorSoldados = Console.ReadLine().Split(' ');

                for (global::System.Int32 j = 0; j < colunasSoldados; j++)
                {
                    matrizSoldados[i, j] = int.Parse(identificadorSoldados[j]);
                }
            }

            int girarFila;
            Console.Write("Girar a fila: ");
            girarFila =int.Parse(Console.ReadLine());

            int[] vetor = new int[colunasSoldados];

            for (int i = 0; i < Mfilas; i++)
            {
                if (i == girarFila - 1)
                {
                    for (global::System.Int32 j = 0; j < colunasSoldados; j++)
                    {
                        if (j == colunasSoldados - 1)
                        {
                            vetor[0] = matrizSoldados[i, j];
                        }
                        else
                        {
                            vetor[j + 1] = matrizSoldados[i, j];
                        }          
                    }
                }
            }

            for (int i = 0; i < Mfilas; i++)
            {
                for (global::System.Int32 j = 0; j < colunasSoldados; j++)
                {
                    if (i == girarFila - 1)
                    {
                        Console.Write($"{vetor[j]} ");
                    }
                    else
                    {
                        Console.Write($"{matrizSoldados[i, j]} ");
                    }
                   
                }

                Console.WriteLine();    
            }

            Console.ReadLine();
        }
    }
}
