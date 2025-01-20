using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2
{
    public class Class1
    {
        private double _t;
        private double _y;
        private double _r;

        public Class1(double t, double y, double r)
        {
            _t = t;
            _y = y;
            _r = r;
        }
        public void W()
        {
            Console.WriteLine($"W = {(4 * Math.Pow(_t, 3) + Math.Log(_r)) / (Math.Exp(_y + _r) + 7.2 * Math.Sin(_r))}");
        }
    }
}
