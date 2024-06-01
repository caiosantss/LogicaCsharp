using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y ,Impares, minimo, maximo;
            
            N = int.Parse(Console.ReadLine());

            for (int contador = 0; contador < N; contador++)
            {
                Impares = 0;
                string[]numeros = Console.ReadLine().Split(' ');
                X = int.Parse(numeros[0]);
                Y = int.Parse(numeros[1]);
                        if (X > Y)
                        {
                            maximo = X;
                            minimo = Y;
                        }
                        else
                        {
                            maximo = Y;
                            minimo = X;
                        }
                for (int i = minimo + 1; i < maximo ; i++)
                {
                    
                    if (i % 2 != 0 )
                    {
                        Impares += i; 
                    }
                    else if(i >= maximo)
                    {
                        Impares = 0;
                    }
                }

                Console.WriteLine(Impares);
            }
            Console.ReadLine();
        }
    }
}
