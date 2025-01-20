using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь5
{
    internal class Class1
    {
        private double _t;
        private double _a;
        private double _y;

        public Class1(double t, double a, double y)
        {
            _t = t;
            _a = a;
            _y = y;
        }
        public void d()
        {
            Console.WriteLine($"D = {(7.8 * Math.Pow(_a, 2) + 3.52 * _t) / (Math.Log(_a + 2 * _y) + Math.Exp(_y))}");
        }
    }
}
