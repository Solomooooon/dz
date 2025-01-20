using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._21
{
    public class Class1
    {
        private double _k;
        private double _p;
        private double _x;
        private double _d;

        public Class1(double k, double p, double x, double d)
        {
            _k = k;
            _p = p;
            _x = x;
            _d = d;
        }
        public void Q()
        {
            Console.WriteLine($"Q = {(Math.Sqrt(_k + 2.6 * _p * Math.Sin(_k))) / (_x - Math.Pow(_d, 3))}");
        }
    }
}
