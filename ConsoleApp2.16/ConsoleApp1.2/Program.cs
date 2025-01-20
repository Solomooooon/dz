using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W, t, r, y;

            Console.WriteLine("Введите значение чила t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            W= (4*Math.Pow(t,3)+Math.Log(r))/(Math.Exp(y+r)+7.2*Math.Sin(r));

            Console.WriteLine($"W = {W}");
        }
    }
}
