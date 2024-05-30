using System;
using System.Globalization;



namespace ex_1017
{
    class Program
    {

        static void Main(string[] args)
        {

            //entradas

            int tempoGastohoras = int.Parse(Console.ReadLine());
            int kilometragemMedia = int.Parse(Console.ReadLine());
            double kilometragemTotal = tempoGastohoras * kilometragemMedia;
            double litrosGastos = (kilometragemTotal / 12);
            Console.WriteLine(litrosGastos.ToString("F3", CultureInfo.InvariantCulture));





        }

    }
}