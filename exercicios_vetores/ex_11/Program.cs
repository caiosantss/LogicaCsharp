using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tem - se um conjunto de dados contendo a altura e o sexo(M, F) de N pessoas.Fazer um programa que calcule e escreva:
                 a maior e a menor altura do
                grupo
                 a média de altura das mulheres 
                 o número de homens  */

            int N;
            Console.WriteLine("Diite o numero de usuarios que serão cadastrados: ");
            N = int.Parse(Console.ReadLine());  

            double [] alturas = new double [N];
            char[] sexos = new char[N];

            Console.WriteLine("Digite os candidatos seguindo o modelo: 'Altura Sexo (F/M)'");

            for (int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);    
                sexos[i] = char.Parse(dados[1]);
            }

            //Realizando a menor e maior altura do grupo. 

            double maiorAltura, menorAltura;
            maiorAltura = menorAltura = alturas[0];

            string sexoMaiorAltura, sexoMenorAltura;
            sexoMaiorAltura = sexoMenorAltura = "";
           

            for (int i = 0; i < N; i++)
            {
               
                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];                  
                    sexoMaiorAltura = sexos[i].ToString();
                }
                else if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                    sexoMenorAltura = sexos[i].ToString();
                }
                
            }

            if (sexoMaiorAltura == "F" || sexoMenorAltura == "F")
            {
                sexoMaiorAltura = "Feminino";
                sexoMenorAltura = "Feminino";
            }
            else
            {
                sexoMaiorAltura = "Masculino";
                sexoMenorAltura = "Masculino";
            }

            Console.WriteLine($"Menor altura: {menorAltura.ToString("F2", CultureInfo.InvariantCulture)}, do sexo: {sexoMenorAltura}");
            Console.WriteLine($"Maior altura: {maiorAltura.ToString("F2", CultureInfo.InvariantCulture)}, do sexo: {sexoMaiorAltura}");

            //Exibindo a media das alturas das mulheres e a media das alturas dos homens

            double somaAlturaFeminino,SomaAlturaMasculino, mediaM, mediaF;
            somaAlturaFeminino = SomaAlturaMasculino = mediaF = mediaM = 0.0;

            double contadorM, contadorF;
            contadorF = contadorM = 0.0;


            for (int i = 0; i < N; i++)
            {
                if (sexos[i] == 'F')
                {
                    somaAlturaFeminino += alturas[i];
                    contadorF++;
                }
                else
                {
                    SomaAlturaMasculino += alturas[i];
                    contadorM++;
                }
            }

            mediaM = SomaAlturaMasculino / contadorM;
            mediaF = somaAlturaFeminino / contadorF;

            Console.WriteLine($"Media das alturas das mulheres: {mediaF.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Numero de mulheres: {contadorF}");

            Console.WriteLine($"Media das alturas dos homens: {mediaM.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Numero de homens: {contadorM}");

            Console.ReadLine();
        }
    }
}
