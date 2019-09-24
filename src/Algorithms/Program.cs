using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ArraysAndStrings>();
        }
    }
}
