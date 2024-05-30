using System;
using System.Linq.Expressions;

namespace ex_1019
{


class URI
{

    static void Main(string[] args)
    {

        //Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos: segundos.

        // 1 hora = 60 minutos = 3600 segundos 
        // 1 minuto = 60 segundos

        int N;
        int segundos;
        int minutos;
        int horas;

        N = int.Parse(Console.ReadLine());
        segundos = N;

        horas = segundos / 3600;
        minutos = (segundos % 3600) / 60;
        segundos = (segundos % 3600) % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);

    }

}
}