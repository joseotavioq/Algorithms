using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    /// <summary>
    /// Given two strings, write a method to decide if one is a permutation
    /// of the other.
    /// </summary>
    [MemoryDiagnoser]
    public class CheckPermutation
    {
        //Time: O(n)
        //Space: O(1)
        [Benchmark(Baseline = true)]
        [Arguments("abcdefgh", "fdceagbh")]
        public bool FirstTry(string first, string second)
        {
            if (first == null || second == null || first.Length != second.Length)
                return false;

            //Assuming the parameters are ASCII
            int[] asciiTable = new int[128];
            for (int i = 0; i < first.Length; i++)
                asciiTable[first[i]]++;

            for (int i = 0; i < second.Length; i++)
            {
                int character = second[i];
                asciiTable[character]--;

                if (asciiTable[character] < 0)
                    return false;
            }

            return true;
        }
        [Benchmark]
        [Arguments("abcdefgh", "fdceagbh")]
        public bool SbyteTry_Vafzamora(string first, string second) {
            if (first == null || second == null || first.Length != second.Length)
                return false;

            //Assuming the parameters are ASCII
            sbyte[] asciiTable = new sbyte[128];
            for (int i = 0; i < first.Length; i++)
                asciiTable[first[i]]++;

            for (int i = 0; i < second.Length; i++) {
                if (--asciiTable[second[i]] < 0)
                    return false;
            }

            return true;
        }


    }
}
