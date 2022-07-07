using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Fatorial de qual numero?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O Fatorial de: " + num + " é: " + Fatorial(num));


            Console.ReadLine();
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            else
            {
                return num * Fatorial(num - 1);
            }

        }
    }
}
