using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista
{
    internal static class Quest7
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CalcularMedia(3.4f,6.8f,9.8f).ToString("F1"));
        }

        static float CalcularMedia(float x, float y, float z)
        {
            return (float) (x + y + z) / 3;
        }
    }
}