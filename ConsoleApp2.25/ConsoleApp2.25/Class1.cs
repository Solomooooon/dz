using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._25
{
    public class Class1
    {
        private double _c;
        private double _t;


        public Class1(double c, double t)
        {
            _c = c;
            _t = t;
        }
        public void L()
        {
            Console.WriteLine($"L = {Math.Pow(Math.Cos(_c), 2) + (3 * Math.Pow(_t, 2) + 4) / (Math.Sqrt(_c + _t))}");
        }
    }
}
