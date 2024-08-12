using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest11
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CalcularFatorial(5));
        }

        static int CalcularFatorial(int n)
        {
            //int total = 0;
            if (n > 1){
                return n * CalcularFatorial(n - 1);
            }
            return n;
        }
    }
}