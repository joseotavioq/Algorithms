using BenchmarkDotNet.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures.
    /// </summary>
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
            //Assuming the parameter is ASCII
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

        [Benchmark]
        [Arguments("abcdefgh")]
        public bool MyTry_Vafzmora(string value)
        {
            //Assuming the parameter is < 128 because every char in CLR is f#ckin' Unicode
            BitArray asciiTable = new BitArray(128);

            for (int i = 0; i < value.Length; i++)
            {
                if (asciiTable[value[i]])
                    return false;
                asciiTable[value[i]] = true;
            }
            return true;
        }
    }
}