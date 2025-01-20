using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, t, l, y;

            Console.WriteLine("Введите значение чила t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            K = (2*Math.Pow(t,2)+3*l+7.2) / (Math.Log(y)+Math.Exp(2*t));

            Console.WriteLine($"K = {K}");
        }
    }
}
