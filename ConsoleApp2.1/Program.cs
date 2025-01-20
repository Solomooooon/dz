using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, y, f;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение f");
            f = Convert.ToDouble(Console.ReadLine());

            G = Math.Exp(2*y) + Math.Sin(f) / Math.Log(3.8 * y +f);
            Console.WriteLine($"G = {G}");

        }
    }
}
