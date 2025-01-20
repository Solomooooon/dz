using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, w, y;

            Console.WriteLine("Введите значение w");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            G = 9.33 * Math.Pow(w, 3) + Math.Sqrt(w) / Math.Log(y + 3.5) +Math.Sqrt(y);
            Console.WriteLine($"G = {G}");
        }
    }
}
