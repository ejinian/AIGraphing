using AwokeKnowing.GnuplotCSharp;
using System;


namespace Graphing
{
    class Program
    {
        static void Main(string[] args)
        {
            GnuPlot.Plot("sin(x) + 2");
            GnuPlot.Write("move");
            Console.ReadLine();
        }
    }
}
