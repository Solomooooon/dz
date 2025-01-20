using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, k, y;

            Console.WriteLine("Введите значение чила k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            R = (Math.Sqrt(Math.Pow(Math.Sin(y),2)+6.835)) / (Math.Log((y+k))+3*Math.Pow(y,2));

            Console.WriteLine($"R = {R}");
        }
    }
}
