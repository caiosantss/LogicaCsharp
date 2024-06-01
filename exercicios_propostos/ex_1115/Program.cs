using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            int X, Y;
            X = int.Parse(coordenadas[0]);
            Y = int.Parse(coordenadas[1]);

            /*
            X > 0 = 1Q ou 4Q 
            X < 0 = 2Q OU 3Q 

            Y > 0 = 1Q OU 2Q
            Y < 0 = 3Q OU 4Q

             X Y 
             1 -1 = 4Q
             1 1 = 1Q
             -1 1 = 2Q 
             -1 -1 = 3Q
             */

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    Console.WriteLine("terceiro");
                }
                coordenadas = Console.ReadLine().Split(' ');
                X = int.Parse(coordenadas[0]);
                Y = int.Parse(coordenadas[1]);

            }   

        }
    }
}
