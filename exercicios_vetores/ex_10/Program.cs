using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. 
                Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados, 
                considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.*/

            int N;
            Console.WriteLine("Quantos alunos serão cadastrados? ");
            N = int.Parse(Console.ReadLine());
            string[] nomeAlunos = new string[N];
            double[] notas1 = new double[N];
            double[] notas2 = new double[N];
            Console.WriteLine("Escreva da seguinte forma: 'Nome do aluno' 'nota 1°bi' 'nota 2° bi' ");
            for (int i = 0; i < N; i++)
            {
                string[] informacoesGerais = Console.ReadLine().Split(' ');
                nomeAlunos[i] = informacoesGerais[0];
                notas1[i] = double.Parse(informacoesGerais[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(informacoesGerais[2], CultureInfo.InvariantCulture);
            }

            double soma, media;
            
            soma = media = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = notas1[i] + notas2[i];
                media = soma / 2.0;

                if (media >= 6)
                {

                    Console.WriteLine($"{nomeAlunos[i]}: Aprovado");
                }
                else
                {
                    Console.WriteLine($"{nomeAlunos[i]}: Reprovado");
                }
            }

            Console.ReadLine();
        
        }
    }
}
