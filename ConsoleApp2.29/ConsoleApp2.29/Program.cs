using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, h, y;

            Console.WriteLine("Введите значение чила h");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (0.355*Math.Pow(h,2)-4.355)/(Math.Exp(y+h)+Math.Sqrt(2.7*y));

            Console.WriteLine($"T = {T}");
        }
    }
}
