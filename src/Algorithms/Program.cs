using Algorithms.ArraysAndStrings;
using Algorithms.HashTables;
using Algorithms.LinkedLists;
using Algorithms.Recursion;
using Algorithms.Sorting;
using Algorithms.Stacks;
using BenchmarkDotNet.Running;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<QuickSort>();
        }
    }
}