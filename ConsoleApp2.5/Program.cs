using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D, a, t, y;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            D = (7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + 2 * y) + Math.Exp(y));
            Console.WriteLine($"D = {D}");
        }
    }
}
