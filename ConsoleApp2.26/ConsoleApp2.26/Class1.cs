using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._26
{
    public class Class1
    {
        private double _u;
        private double _y;


        public Class1(double u, double y)
        {
            _u = u;
            _y = y;
        }
        public void T()
        {
            Console.WriteLine($"T = {(Math.Sin((2 * _u))) / (Math.Log((2 * _y + _u)))}");
        }
    }
}
