using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).            
             Se o ponto estiver na origem, escreva a mensagem “Origem”.
             Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.             
             
             RESOLUÇÃO: 

               y = 0 origem ;
                y > 0 -> Q1 || Q2;
                y < 0 -> Q3 || Q4;

               x = 0 origem;
               x > 0 -> Q1 || Q4;
               x < 0 -> Q2 || Q3;
 
                (X Y)
                 0 0 = ORIGEM
                 0 1 = Eixo y
                 1 0 = Eixo x
                 + +  = Q1
                 + - = Q4
                 - + = Q2
                 - - = Q3
                */

            double coordenadaX, coordenadaY;
            string quadrante;

            string[] coordenadas = Console.ReadLine().Split(' ');
            coordenadaX = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            coordenadaY = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (coordenadaX == 0 && coordenadaY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (coordenadaX > 0 && coordenadaY > 0)
            {
                quadrante = "Q1";
                Console.WriteLine(quadrante);
            }   
            else if (coordenadaX > 0 && coordenadaY < 0)
            {
                quadrante = "Q4";
                Console.WriteLine(quadrante);
            }
            else if (coordenadaX < 0 && coordenadaY > 0)
            {
                quadrante = "Q2";
                Console.WriteLine(quadrante);
            }
            else if (coordenadaX < 0 && coordenadaY < 0)
            {
                quadrante = "Q3";
                Console.WriteLine(quadrante);
            } else if (coordenadaX == 0 && coordenadaY > 0 || coordenadaY < 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (coordenadaY == 0 && coordenadaX > 0 || coordenadaX < 0)
            {
                Console.WriteLine("Eixo X");
            }
            Console.ReadLine();

        }
    }
}
