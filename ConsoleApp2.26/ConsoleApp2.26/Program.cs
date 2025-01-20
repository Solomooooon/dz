using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, u, y;

            Console.WriteLine("Введите значение чила u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (Math.Sin((2 * u))) / (Math.Log((2*y+u)));

            Console.WriteLine($"T = {T}");
        }
    }
}
