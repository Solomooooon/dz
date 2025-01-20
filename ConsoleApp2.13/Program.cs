using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, y, h;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Convert.ToDouble(Console.ReadLine());

            A = (Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Exp(h) + y);
            Console.WriteLine($"A = {A}");

        }
    }
}
