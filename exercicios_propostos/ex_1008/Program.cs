using System;
using System.Globalization;


namespace ex_1008
{
    class Program
    {

        static void Main(string[] args)
        {
            // Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            int numeroFuncionario, horasTrabalhadas;
            double salario,valorPorHora ;

            Console.WriteLine("Numero do funcionario: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora trabalhada: ");
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}