using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._18
{
    public class Class1
    {
        private double _k;
        private double _y;


        public Class1(double k, double y)
        {
            _k = k;
            _y = y;
        }
        public void R()
        {
            Console.WriteLine($"R = {(Math.Sqrt(Math.Pow(Math.Sin(_y), 2) + 6.835)) / (Math.Log((_y + _k)) + 3 * Math.Pow(_y, 2))}");
        }
    }
}
