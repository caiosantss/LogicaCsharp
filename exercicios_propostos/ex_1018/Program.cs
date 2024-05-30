using System;


namespace ex_1018 {
class URI
{

    static void Main(string[] args)
    {
            //Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
            int N, quociente, resto, nota; 

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            nota = 100;
            quociente = N / nota;
            resto = N % nota; 
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

            nota = 50;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");


            nota = 20;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

            nota = 10;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

            nota = 5;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");


            nota = 2;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");


            nota = 1;
            Console.WriteLine(resto + " nota(s) de R$ " + nota + ",00");


        }

    }

}