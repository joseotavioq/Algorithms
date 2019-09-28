using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class IsUnique
    {
        //Time: O(n)
        //Space: O(n)
        [Benchmark(Baseline = true)]
        [Arguments("abcdefgh")]
        public bool FirstTry(string value)
        {
            HashSet<char> mappedChars = new HashSet<char>();

            for (int i = 0; i < value.Length; i++)
            {
                if (mappedChars.Contains(value[i]))
                    return false;

                mappedChars.Add(value[i]);
            }

            return true;
        }

        //Time: O(n)
        //Space: O(1)
        [Benchmark]
        [Arguments("abcdefgh")]
        public bool SecondTry(string value)
        {
            //Assuming that the parameters is an ASCII string
            bool[] asciiTable = new bool[128];

            for (int i = 0; i < value.Length; i++)
            {
                int charInNumber = value[i];

                if (asciiTable[charInNumber])
                    return false;

                asciiTable[charInNumber] = true;
            }

            return true;
        }
    }
}