using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, k, y;

            Console.WriteLine("Введите значение k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            U = Math.Log(k - y) + Math.Pow(y, 4) / Math.Exp(y) + 2.355 * Math.Pow(k, 2);
            Console.WriteLine($"U = {U}");
        }
    }
}
