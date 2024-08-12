using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest6
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18){
                Console.Write("Você é menor de idade");
                if (idade >= 16){
                    Console.WriteLine(", mas pode votar.");
                }else {
                    Console.WriteLine(" e você também não pode votar nem dirigir.");
                }
            }else{
                Console.WriteLine("Você é maior de idade, pode dirigir e pode votar.");
            }
        }
    }
}