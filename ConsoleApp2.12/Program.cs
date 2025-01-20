using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, t, y;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            R = (Math.Pow(Math.Sin(2 * t + 1), 2) + 0.3) / (Math.Log(t + y));
            Console.WriteLine($"R = {R}");

        }
    }
}
