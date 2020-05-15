using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    /// <summary>
    /// There are three types of edits that can be performed on strings:
    /// insert a character, remove a character, or replace a character.
    /// Given two strings, write a function to check if they are one edit
    /// (or zero edits) aaway.
    /// </summary>
    [MemoryDiagnoser]
    public class OneAway
    {
        //Time: O(n)
        //Space: O(1)
        [Benchmark(Baseline = true)]
        [Arguments("pale", "bae")]
        public bool FirstTry(string first, string second)
        {
            bool onlyOneEdit = false;

            //Assuming the parameters are ASCII
            int[] asciiTable = new int[128];
            for (int i = 0; i < first.Length; i++)
                asciiTable[first[i]]++;

            for (int i = 0; i < second.Length; i++)
            {
                char character = second[i];
                asciiTable[character]--;

                if (asciiTable[character] < 0)
                {
                    if (!onlyOneEdit)
                        onlyOneEdit = true;
                    else
                        return false;
                }
            }

            onlyOneEdit = false;
            for (int i = 0; i < asciiTable.Length; i++)
            {
                if (asciiTable[i] > 0)
                {
                    if (!onlyOneEdit)
                        onlyOneEdit = true;
                    else
                        return false;
                }
            }

            return true;
        }

        //Time: O(n)
        //Space: O(1)
        [Benchmark]
        [Arguments("pale", "bae")]
        public bool Fast(string first, string second)
        {
            if (first.Length - second.Length > 1)
                return false;

            string f = null;
            string s = null;

            if (first.Length < second.Length)
            {
                f = first;
                s = second;
            }
            else
            {
                f = second;
                s = first;
            }

            int indexOfFirst = 0;
            int indexOfSecond = 0;
            bool foundDifference = false;

            while (indexOfFirst < f.Length && indexOfSecond < s.Length)
            {
                if (f[indexOfFirst] != s[indexOfSecond])
                {
                    if (foundDifference)
                        return false;

                    foundDifference = true;

                    if (f.Length == s.Length)
                        indexOfFirst++;
                }
                else
                {
                    indexOfFirst++;
                }
                indexOfSecond++;
            }

            return true;
        }
    }
}