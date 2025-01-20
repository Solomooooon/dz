using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._27
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
        public void Z()
        {
            Console.WriteLine($"Z = {(Math.Sin(Math.Pow((_p + 0.4), 2))) / (Math.Pow(_y, 2) + 7.325 * _p)}");
        }
    }
}
