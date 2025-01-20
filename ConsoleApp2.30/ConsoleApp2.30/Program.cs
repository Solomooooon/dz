using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, p, y;

            Console.WriteLine("Введите значение чила p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            N = (3*Math.Pow(y,2)+Math.Sqrt(y+1))/Math.Log((p+y))+Math.Exp(p);

            Console.WriteLine($"N = {N}");
        }
    }
}
