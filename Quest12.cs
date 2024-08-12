using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest12
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite o tanto de sequencias que você quer: ");
            int input = int.Parse(Console.ReadLine());

            if (input > 0){
                int i = 1;
                while (i <= input){
                    Console.Write(Fibonacci(i) + " ");
                    i++;
                }
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 2){
                return 1;
            }else{
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}