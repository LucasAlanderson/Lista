using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest2
    {
        private static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Math(x,y));
        }

        static string Math(int x,int y)
        {
            return ("Soma: " + (x + y) + "\n") + ("Subtração: " + (x - y) + "\n") + ("Multiplicação: " + (x * y) + "\n") + ("Divisão: " + (x / y) + "\n");
        }
    }
}