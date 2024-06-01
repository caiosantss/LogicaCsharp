using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, num;
            
            N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            string[] s = Console.ReadLine().Split(' ');    

            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);             
               
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                    
                }
            }
           
            Console.ReadLine();
        }
    }
}
