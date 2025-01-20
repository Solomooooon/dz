using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, i, y;

            Console.WriteLine("Введите значение i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            L = (0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(i, 3));
            Console.WriteLine($"L = {L}");
        }
    }
}
