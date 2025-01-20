using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, y, h;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Convert.ToDouble(Console.ReadLine());

            P = (Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3)) / (Math.Log(Math.Sqrt(y + 0.4 * h)));
            Console.WriteLine($"P = {P}");
        }
    }
}
