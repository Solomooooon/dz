using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь1
{
    internal class Class1
    {
        private double _f;
        private double _y;

        public Class1(double f, double y)
        {
            _f = f;
            _y = y;
        }
        public void G()
        {
            Console.WriteLine($"G = {Math.Exp(2 * _y) + Math.Sin(_f) / Math.Log(3.8 * _y + _f)}");
        }
    }
}
