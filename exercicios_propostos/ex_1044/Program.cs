using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

            int A, B;
            string[] multiplos = Console.ReadLine().Split(' ');
            A = int.Parse(multiplos[0]);
            B = int.Parse(multiplos[1]);

            if (A < B && (B % A == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (A > B && (A % B == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }            
        }
    }
}
