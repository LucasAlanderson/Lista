using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest9
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um n�mero. Se esse n�mero for diferente de 0, ele ser� somado, sen�o, o programa encerra.");
            int total = 0;
            int nums;
            do {
                nums = int.Parse(Console.ReadLine());
                total += nums;
            }while (nums != 0);

            Console.WriteLine("Total da soma: {0}", total);
        }
    }
}