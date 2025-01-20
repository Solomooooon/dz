using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, d, y;

            Console.WriteLine("Введите значение d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            F = Math.Log(d) + 3.5 * Math.Pow(d, 2) + 1 / Math.Cos(2) * y;
            Console.WriteLine($"F = {F}");
        }
    }
}
