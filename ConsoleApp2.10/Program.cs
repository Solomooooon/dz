using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь_10
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double Z, t, y;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Z = (2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831));
            Console.WriteLine($"Z = {Z}");
        }
    }
}
