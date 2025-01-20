using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._30
{
    public class Class1
    {
        private double _p;
        private double _y;


        public Class1(double p, double y)
        {
            _p = p;
            _y = y;
        }
        public void N()
        {
            Console.WriteLine($"N = {(3 * Math.Pow(_y, 2) + Math.Sqrt(_y + 1)) / Math.Log((_p + _y)) + Math.Exp(_p)}");
        }
    }
}
