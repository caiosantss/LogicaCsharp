using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ex_1097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 7;
            for (int i = 1; i <= 9 ; i+=2)
            {
                Console.WriteLine($"I = {i} J = {j}");
                Console.WriteLine($"I = {i} J = {j - 1}");
                Console.WriteLine($"I = {i} J = {j - 2}");

                j = j + 2;
            }
            Console.ReadLine();
        }
    }
}
