using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ясь8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, t, y;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5));
            
            Console.WriteLine($"T = {T}");

        }
    }
}
