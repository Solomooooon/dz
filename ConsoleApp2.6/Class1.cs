using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь6
{
    internal class Class1
    {
        private double _i;
        private double _y;

        public Class1(double i, double y)
        {
            _i = i;
            _y = y;
        }
        public void L()
        {
            Console.WriteLine($"L = {(0.81 * Math.Cos(_i)) / (Math.Log(_y) + 2 * Math.Pow(_i, 3))}");
        }
    }
}
