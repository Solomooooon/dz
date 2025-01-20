using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь9
{
    internal class Class1
    {
        private double _y;
        private double _w;

        public Class1(double y, double w)
        {
            _y = y;
            _w = w;
        }
        public void V()
        {
            Console.WriteLine($"V = {(Math.Pow((_y + 2 * _w), 3)) / (Math.Log(_y + 0.75))}");
        }
    }
}
