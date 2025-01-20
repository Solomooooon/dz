using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._20
{
    public class Class1
    {
        private double _t;
        private double _y;
        private double _l;

        public Class1(double t, double y, double l)
        {
            _t = t;
            _y = y;
            _l = l;
        }
        public void K()
        {
            Console.WriteLine($"K = {(2 * Math.Pow(_t, 2) + 3 * _l + 7.2) / (Math.Log(_y) + Math.Exp(2 * _t))}");
        }
    }
}
