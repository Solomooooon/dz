using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь3
{
    internal class Class1
    {
        private double _k;
        private double _y;

        public Class1(double k, double y)
        {
            _k = k;
            _y = y;
        }
        public void U()
        {
            Console.WriteLine($"U = {Math.Log(_k - _y) + Math.Pow(_y, 4) / Math.Exp(_y) + 2.355 * Math.Pow(_k, 2)}");
        }
    }
}
