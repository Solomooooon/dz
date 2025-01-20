using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._19
{
    public class Class1
    {
        private double _q;
        private double _y;


        public Class1(double q, double y)
        {
            _q = q;
            _y = y;
        }
        public void E()
        {
            Console.WriteLine($"E = {(Math.Log((0.7 * _y + 2 * _q))) / (Math.Sqrt(3 * Math.Pow(_y, 2) + 0.5 * _y + 4))}");
        }
    }
}
