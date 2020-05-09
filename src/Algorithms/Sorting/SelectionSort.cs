using BenchmarkDotNet.Attributes;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class SelectionSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                int indexOfMin = i;

                for (int j = i + 1; j < listOfNumbers.Length; j++)
                {
                    if (listOfNumbers[j] < listOfNumbers[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }

                if (indexOfMin != i)
                {
                    var tmp = listOfNumbers[i];
                    listOfNumbers[i] = listOfNumbers[indexOfMin];
                    listOfNumbers[indexOfMin] = tmp;
                }
            }

            return listOfNumbers;
        }
    }
}