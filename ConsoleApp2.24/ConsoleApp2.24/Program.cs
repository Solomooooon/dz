using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, k, y;

            Console.WriteLine("Введите значение чила k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log((2*k+4.3))) / (Math.Exp(k+y)+Math.Sqrt(y));

            Console.WriteLine($"U = {U}");
        }
    }
}
