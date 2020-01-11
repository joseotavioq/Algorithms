using BenchmarkDotNet.Attributes;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class InsertionSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            int lastJ = 0;

            for (int i = 0; i < listOfNumbers.Length - 1; i++)
            {
                int j = i + 1;
                lastJ = j;

                while (listOfNumbers[i] > listOfNumbers[j])
                {
                    var tmp = listOfNumbers[i];
                    listOfNumbers[i] = listOfNumbers[j];
                    listOfNumbers[j] = tmp;

                    if (i > 0)
                    {
                        i--;
                        j--;
                    }
                }

                i = lastJ - 1;
                j = lastJ;
            }

            return listOfNumbers;
        }

        [Benchmark]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
        public int[] SecondTry(int[] listOfNumbers)
        {
            for (var i = 1; i < listOfNumbers.Length; i++)
            {
                var atual = listOfNumbers[i];
                var j = i;
                while ((j > 0) && (listOfNumbers[j - 1] > atual))
                {
                    listOfNumbers[j] = listOfNumbers[j - 1];
                    j -= 1;
                }
                listOfNumbers[j] = atual;
            }

            return listOfNumbers;
        }
    }
}