using BenchmarkDotNet.Attributes;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class SelectionSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 5, 10, 3, 2, 4 })]
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