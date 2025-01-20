using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь11
{
    internal class Class1
    {
        private double _y;
        private double _n;

        public Class1(double y, double n)
        {
            _n = n;
            _y = y;
        }
        public void D()
        {
            Console.WriteLine($"D = {Math.Pow(_y, 2) + (0.5 * _n + 4.8) / (Math.Sin(_y))}");
        }
    }
}
