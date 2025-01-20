using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь13
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
        public void A()
        {
            Console.WriteLine($"A = {(Math.Sin(2 * _y + _h) + Math.Pow(_h, 2)) / (Math.Exp(_h) + _y)}");
        }
    }
}
