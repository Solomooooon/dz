using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ясь4
{
    internal class Class1
    {
        private double _w;       
        private double _y;

        public Class1(double w, double y)
        {
            _w = w;
            _y = y;
        }
        public void G()
        {
            Console.WriteLine($"G = {9.33 * Math.Pow(_w, 3) + Math.Sqrt(_w) / Math.Log(_y + 3.5) +Math.Sqrt(_y)}");
        }
    }
}
