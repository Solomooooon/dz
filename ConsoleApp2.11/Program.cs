using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D, y, n;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y));
            Console.WriteLine($"R = {D}");
        }
    }
}
