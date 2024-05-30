using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1045
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

            se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
            se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO

            se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES*/

            string[] numeros = Console.ReadLine().Split(' ');
              
            double l1  = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double l2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double l3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            double[] lados = new double[] { l1, l2, l3 };

             // Colocando em ordem decrescente 

            

            if (l1 < l2 || l1 < l3)
            {
                lados[0] = l1;
                lados[1] = l2;
                lados[2] = l3;
                Array.Sort(lados);
                Array.Reverse(lados);              
           
           

            //tipos de triangulo 

            if (l1 > l2 + l3)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (l1 * l1 == (l2 * l2) + (l3 * l3))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if(l1 * l1 > (l2 * l2) + (l3 * l3))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (l1 * l1 < (l2 * l2) + (l3 * l3))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            // Triangulo isosceles ou equilatero


            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

            }
            Console.ReadLine();
        }
    }
}
