using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest10
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite quantos reias você quer converter: ");
            float real = float.Parse(Console.ReadLine());
            Console.Write("Digite a taxa: ");
            float taxa = float.Parse(Console.ReadLine());

            float total = (float) real / taxa;
            Console.Write("{0}$",total.ToString("F2"));
        }
    }
}