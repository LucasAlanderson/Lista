using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest3
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá {0}, você tem {1} anos.",nome,idade);
            
        }
    }
}