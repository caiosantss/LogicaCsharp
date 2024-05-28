using System;


namespace ex_1007
{
        class Program
        {

            static void Main(string[] args)
            {
            // Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            
                int A, B, C, D, Diferenca;

                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
      
                Diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENÇA = " + Diferenca);


        }

    }
}