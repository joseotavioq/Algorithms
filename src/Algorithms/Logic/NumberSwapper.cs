using BenchmarkDotNet.Attributes;
using System;

namespace Algorithms.Logic
{
    /// <summary>
    /// Write a function to swap a number in place (that is, without temporary variables)
    /// </summary>
    [MemoryDiagnoser]
    public class NumberSwapper
    {
        [Benchmark(Baseline = true)]
        [Arguments(15000, 8250)]
        public (int, int) FirstTry(int x, int y)
        {
            if (x != y)
            {
                //checked //this will throw an OverflowException
                //{
                x = x + y;
                y = x - y;
                x = x - y;
                //}
            }

            return (x, y);
        }

        [Benchmark]
        [Arguments(15000, 8250)]
        public (int, int) SecondTry(int x, int y)
        {
            //x = 10; //1010
            //y = 8;  //1000

            if (x != y)
            {
                x = x ^ y; //1010 (10) ^ 1000 (8)  = 0010 = 2
                y = x ^ y; //0010 (2)  ^ 1000 (8)  = 1010 = 10
                x = x ^ y; //0010 (2)  ^ 1010 (10) = 1000 = 8
            }

            return (x, y);
        }
    }
}