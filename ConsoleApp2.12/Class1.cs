using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь12
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
        public void R()
        {
            Console.WriteLine($"R = {(Math.Pow(Math.Sin(2 * _t + 1), 2) + 0.3) / (Math.Log(_t + _y))}");
        }
    }
}
