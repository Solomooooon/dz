using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._23
{
    public class Class1
    {
        private double _d;
        private double _y;


        public Class1(double d, double y)
        {
            _d = d;
            _y = y;
        }
        public void R()
        {
            Console.WriteLine($"R = {(Math.Pow(Math.Sin(_y), 2) + 0.3 * _d) / (Math.Exp(_y) + Math.Log(_d))}");
        }
    }
}
