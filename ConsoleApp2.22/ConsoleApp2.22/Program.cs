using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S, t, y;

            Console.WriteLine("Введите значение чила t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            S = (4.351*Math.Pow(y,3)+2*t*Math.Log(t)) / (Math.Sqrt(Math.Cos((2*y))+4.351));

            Console.WriteLine($"S = {S}");
        }
    }
}
