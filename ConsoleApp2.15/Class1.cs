using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь15
{
    internal class Class1
    {
        private double _y;
        private double _j;

        public Class1(double y, double j)
        {
            _y = y;
            _j = j;
        }
        public void F()
        {
            Console.WriteLine($"F = {(2 * Math.Sin(0.354 * _y + 1)) / (Math.Log(_y + 2 * _j))}");
        }
    }
}
