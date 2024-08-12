using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest8
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int[] input = { x, y, z };

            Array.Sort(input);

            Console.WriteLine("{0} é o menor e {1} é o maior.",input.Min(),input.Max());
        }
    }
}