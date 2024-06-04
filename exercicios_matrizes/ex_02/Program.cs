using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler um número inteiro N e uma matriz quadrada de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.

            int Ordem;
            int[,] matrizQuadrada;
            Console.WriteLine("Digite qual sera a ordem da matriz quadratica: ");
            Ordem = int.Parse(Console.ReadLine());
            matrizQuadrada = new int[Ordem, Ordem];


            // ATRIBUINDO ELEMENTOS NAS LINHAS E COLUNAS 

            for (int i = 0; i < Ordem; i++)
            {
                string[] elementos = Console.ReadLine().Split(' '); 
                for (global::System.Int32 j = 0; j < Ordem; j++)
                {
                    matrizQuadrada[i, j] = int.Parse(elementos[j]);
                }
            }

            // EXIBINDO A DIAGONAL PRINCIPAL

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < Ordem; i++)
            {
                Console.Write($"{matrizQuadrada[i, i]} ");
            }

            Console.WriteLine();

            // CONTAGEM DE NUMEROS NEGATIVOS

            int contagem = 0;
            for (int i = 0; i < Ordem; i++)
            {
                for (global::System.Int32 j = 0; j < Ordem; j++)
                {
                    if (matrizQuadrada[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.WriteLine($"QUANTIDADE DE NUMEROS NEGATIVOS: {contagem}");
            Console.ReadLine(); 



        }
    }
}
