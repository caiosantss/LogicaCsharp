using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;
            Console.WriteLine("Digite quantos elementos os vetores terão: ");
            N = int.Parse(Console.ReadLine());
           
            int [] numeros1 = new int[N];
            int[] numeros2 = new int[N];
            int[] somaNumeros = new int[N];

            Console.WriteLine("Digite os elementos do primeiro vetor: ");
            string[] A = Console.ReadLine().Split(' ');
   
            Console.WriteLine("Digite os elementos do segundo vetor: ");
            string[] B = Console.ReadLine().Split(' ');
           
            for (int i = 0; i < N; i++)
            {
                numeros1[i] = int.Parse(A[i]);
                numeros2[i] = int.Parse(B[i]);              

            }


            Console.WriteLine("Elementos do vetor 1: ");
            foreach (int item in numeros1)
            {
                
                Console.Write(item + " ");
                
            }

            Console.WriteLine(" ");

            Console.WriteLine("Elementos do vetor 2: ");


            foreach (int item2 in numeros2)
            {
               
                Console.Write(item2 + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < N; i++)
            {
                somaNumeros[i] = numeros1[i] + numeros2[i];
            }

            Console.WriteLine("Soma dos vetores: ");
            

            foreach (int somaItems in somaNumeros)
            {
                Console.Write(somaItems + " ");
            }

            Console.ReadLine();
        }
    }
}
