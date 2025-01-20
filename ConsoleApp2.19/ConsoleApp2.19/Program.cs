using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double E, q, y;

            Console.WriteLine("Введите значение чила q");
            q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            E = (Math.Log((0.7*y+2*q))) / (Math.Sqrt(3*Math.Pow(y,2)+0.5*y+4));

            Console.WriteLine($"E = {E}");
        }
    }
    
}
