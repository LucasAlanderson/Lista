using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest4
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0) { Console.WriteLine("O número é igual a zero."); }
            else{
                if (num > 0) { Console.WriteLine("O número é positivo."); }
                else { Console.WriteLine("O número é negativo."); }
            }
        }
    }
}