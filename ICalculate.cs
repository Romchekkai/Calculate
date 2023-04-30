using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     interface ICalculate
    {
        double Sum(double a, double b)
        {
            return a + b;
        }
    }
     interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
