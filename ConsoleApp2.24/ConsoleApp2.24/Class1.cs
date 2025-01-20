using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._24
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
        public void U()
        {
            Console.WriteLine($"U = {(Math.Log((2 * _k + 4.3))) / (Math.Exp(_k + _y) + Math.Sqrt(_y))}");
        }
    }
}
