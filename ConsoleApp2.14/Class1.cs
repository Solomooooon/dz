using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь_14
{
    internal class Class1
    {
        private double _y;
        private double _h;

        public Class1(double y, double h)
        {
            _y = y;
            _h = h;
        }
        public void P()
        {
            Console.WriteLine($"P = {(Math.Exp(_y + 2.5) + 7.1 * Math.Pow(_h, 3)) / (Math.Log(Math.Sqrt(_y + 0.4 * _h)))}");
        }
    }
}
