using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ясь8
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
        public void T()
        {
            Console.WriteLine($"T = {(2.37 * Math.Sin(_t + 1)) / (Math.Sqrt(4 * Math.Pow(_y, 2) - 0.1 * _y + 5))}");
        }
    }
}
