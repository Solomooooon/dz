using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, d, y;

            Console.WriteLine("Введите значение чила d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            R = (Math.Pow(Math.Sin(y),2)+0.3*d) / (Math.Exp(y)+Math.Log(d));

            Console.WriteLine($"R = {R}");
        }
    }
}
