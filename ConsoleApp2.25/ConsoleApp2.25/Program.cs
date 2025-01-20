using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, c, t;

            Console.WriteLine("Введите значение чила c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила t");
            t = Convert.ToDouble(Console.ReadLine());

            L = Math.Pow(Math.Cos(c),2)+(3*Math.Pow(t,2)+4)/(Math.Sqrt(c+t));

            Console.WriteLine($"L = {L}");
        }
    }
}
