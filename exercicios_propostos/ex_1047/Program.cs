using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1047
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

                Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
            
             Saída:
                Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” 
            .*/

            int horasINICIO, minutosINICIO, horasFINAIS, minutosFINAIS, saldoFinal, saldoHoras, saldoMinutos;

            string[] numeroHoras = Console.ReadLine().Split(' ');   
            horasINICIO = int.Parse(numeroHoras[0]);
            minutosINICIO = int.Parse(numeroHoras[1]);
            horasFINAIS = int.Parse(numeroHoras[2]);
            minutosFINAIS = int.Parse(numeroHoras[3]);

            // 1 hora == 60 minutos == 3600 segundos

           horasINICIO = horasINICIO * 60 * 60;
            minutosINICIO *= 60;
            horasFINAIS = horasFINAIS * 60 * 60;
            minutosFINAIS *= 60;

            saldoFinal = (horasFINAIS + minutosFINAIS) - (horasINICIO + minutosINICIO);

           // O saldo final negativo indica que as horas finais foram menores que as iniciais, passando para outro dia portanto, sendo assim fazemos as horas e minutos iniciais restantes até 00:00, e após isso apenas somaremos até as horas finais do dia seguinte. 
            
            if (saldoFinal < 0)
            {

                saldoFinal = (86400 - (horasINICIO + minutosINICIO)) + (horasFINAIS + minutosFINAIS);
            }

            if (saldoFinal == 0) 
            {
                saldoHoras = 24;
                saldoMinutos = 0;

                Console.WriteLine("O JOGO DUROU " + saldoHoras +  " HORA(S) E " + saldoMinutos + " MINUTO(S)");
            }
            else if (saldoFinal < 3600)
            {
                saldoHoras = 0;
                saldoMinutos = saldoFinal / 60;

                Console.WriteLine("O JOGO DUROU " + saldoHoras + " HORA(S) E " + saldoMinutos + " MINUTO(S)");
            }
            else if (saldoFinal > 3600)
            {
                saldoHoras = (saldoFinal / 60) / 60;
                saldoMinutos = (saldoFinal / 60) % 60;
                Console.WriteLine("O JOGO DUROU " + saldoHoras + " HORA(S) E " + saldoMinutos + " MINUTO(S)");
            }


            Console.ReadLine();
        }
    }
}
