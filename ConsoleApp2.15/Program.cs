using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, y, j;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение j");
            j = Convert.ToDouble(Console.ReadLine());

            F = (2 * Math.Sin(0.354 * y +1)) / (Math.Log(y + 2 * j));
            Console.WriteLine($"F = {F}");

        }
    }
}
