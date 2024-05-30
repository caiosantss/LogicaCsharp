using System;


namespace ex_1020
{

    class URI
    {

        static void Main(string[] args)
        {
            /*Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
            
            1 ano = 365 dias 
            1 mes = 30 dias 


             */

            int Ndias, quociente, resto, umAno, umMes;

            umAno = 365;
            umMes = 30;

            Ndias = int.Parse(Console.ReadLine());


            //Quantidade de anos 
            quociente = Ndias / umAno;
            resto = Ndias % umAno;
           Console.WriteLine(quociente + " ano(s)");

            //Quantidade de meses 
            quociente = resto / umMes;
            Console.WriteLine(quociente + " mes(es)");

            //Quantidade de dias 
            quociente = resto % umMes;
            Console.WriteLine(quociente + " dia(s)");
        }

    }
}