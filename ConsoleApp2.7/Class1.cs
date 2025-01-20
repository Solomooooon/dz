using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ясь7
{
    internal class Class1
    {
        private double _m;
        private double _y;

        public Class1(double m, double y)
        {
            _m = m;
            _y = y;
        }
        public void N()
        {
            Console.WriteLine($"N = {(3 * Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2) * _y + Math.Pow(3, 6))}");
        }
    }
}
