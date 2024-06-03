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
        {
            int N, idadeMaisVelho;
            string pessoaMaisVelha;
           

            Console.WriteLine("Quantos clientes serão cadastrados?");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            Console.WriteLine("Digite o nome e a idade de cada cliente seguindo o modelo 'CAIO 18' :");
            string[] vetor = new string[N * 2]; 

            for (int i = 0; i < N; i++)
            {
                vetor = Console.ReadLine().Split(' ');
                nomes[i] = vetor[0];
                idades[i] = int.Parse(vetor[1]);
            }
 
            //Verificando quem é o cliente mais velho
            idadeMaisVelho = 0;
            pessoaMaisVelha = "";
            for (int i = 0; i < N; i++)
            {
                if (idades[i] > idadeMaisVelho)
                {
                    idadeMaisVelho = idades[i];
                    pessoaMaisVelha = nomes[i];
                }
            }

            Console.WriteLine($"O cliente mais velho é {pessoaMaisVelha} com {idadeMaisVelho} anos de idade");
            Console.ReadLine();
        }
    }
}
