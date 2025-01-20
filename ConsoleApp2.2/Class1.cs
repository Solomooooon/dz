using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь2
{
    internal class Class1
    {
        private double _d;
        private double _y;

        public Class1(double d, double y)
        {
            _d = d;
            _y = y;
        }
        public void F()
        {
            Console.WriteLine($"F = {Math.Log(_d) + 3.5 * Math.Pow(_d, 2) + 1 / Math.Cos(2) * _y}");
        }
    }
}
