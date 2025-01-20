using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._29
{
    public class Class1
    {
        private double _h;
        private double _y;


        public Class1(double h, double y)
        {
            _h = h;
            _y = y;
        }
        public void T()
        {
            Console.WriteLine($"T = {(0.355 * Math.Pow(_h, 2) - 4.355) / (Math.Exp(_y + _h) + Math.Sqrt(2.7 * _y))}");
        }
    }
}
