using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Q, k, p, x, d;

            Console.WriteLine("Введите значение чила k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила d");
            d = Convert.ToDouble(Console.ReadLine());

            Q = (Math.Sqrt(k+2.6*p*Math.Sin(k))) / (x-Math.Pow(d,3));

            Console.WriteLine($"Q = {Q}");
        }
    }
}
