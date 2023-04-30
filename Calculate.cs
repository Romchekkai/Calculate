using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculate : ICalculate
    {
        ILogger Logger { get; }
        public Calculate(ILogger logger) { Logger = logger; }
        public double Sum(double a, double b)
        {
            Logger.Event($"Sum {a} & {b} = {a + b}");

            return a + b;
        }
    }
    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        void ILogger.Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}