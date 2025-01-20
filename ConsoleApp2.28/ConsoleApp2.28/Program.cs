using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W, v, y;

            Console.WriteLine("Введите значение чила v");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            W = (0.004*v+Math.Exp(2*y))/Math.Exp(y/2);

            Console.WriteLine($"W = {W}");
        }
    }
}
