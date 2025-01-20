using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V, y, w;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение w");
            w = Convert.ToDouble(Console.ReadLine());

            V = (Math.Pow((y + 2 * w), 3)) / (Math.Log(y + 0.75));
            Console.WriteLine($"R = {V}");
        }
    }
}
