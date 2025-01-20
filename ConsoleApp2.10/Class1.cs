using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь_10
{
    internal class Class1
    {
        private double _t;
        private double _y;

        public Class1(double t, double y)
        {
            _t = t;
            _y = y;
        }
        public void Z()
        {
            Console.WriteLine($"Z = {(2 * _t + _y * Math.Cos(_t)) / (Math.Sqrt(_y + 4.831))}");
        }
    }
}
