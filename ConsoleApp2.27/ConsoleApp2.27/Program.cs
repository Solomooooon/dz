using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Z, p, y;

            Console.WriteLine("Введите значение чила p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила y");
            y = Convert.ToDouble(Console.ReadLine());

            Z = (Math.Sin(Math.Pow((p+0.4),2)))/(Math.Pow(y,2)+7.325*p);

            Console.WriteLine($"Z = {Z}");
        }
    }
}
