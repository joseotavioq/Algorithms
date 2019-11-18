using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HashTables
{
    [MemoryDiagnoser]
    public class ContainsCommonItem
    {
        //Time: O(n*m)
        //Space: O(1)
        [Benchmark(Baseline = true)]
        [Arguments(new string[] { "A", "B", "C", "D" }, new string[] { "E", "F", "A", "H" })]
        public bool FirstTry(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        return true;
                }
            }

            return false;
        }

        //Time: O(n)
        //Space: O(n)
        [Benchmark]
        [Arguments(new string[] { "A", "B", "C", "D" }, new string[] { "E", "F", "A", "H" })]
        public bool SecondTry(string[] arr1, string[] arr2)
        {
            var hash = new HashSet<string>(arr1.Length);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!hash.Contains(arr1[i]))
                    hash.Add(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (hash.Contains(arr2[i]))
                    return true;
            }

            return false;
        }
    }
}