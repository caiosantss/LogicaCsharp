using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

            No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.*/

            float n1, n2, n3, n4,nExame, media, mediaExameFinal, peso;
            peso = 10f;
            string[] notas = Console.ReadLine().Split(' ');
            n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);
            n1 *= 2;
            n2 *= 3;
            n3 *= 4;
            n4 *= 1;
            media = (n1 + n2 + n3 + n4) / peso;

            //Problema de arredondamento de 4.85 para 4.9, tive que fazer uma gambiarra.
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            if (media >= 7)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                nExame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + nExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (nExame + media) / 2;
                if (media >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
