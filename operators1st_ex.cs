using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;

            int z = (x + y)/2 + y++ + ++y + 2*(x--*4);
            int w = z++ + (w = z) - --w;
            Console.WriteLine("{0} {1} {2} {3}", x,y,w,z);
            Console.ReadLine();
        }


    }
}