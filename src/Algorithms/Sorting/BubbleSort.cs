using BenchmarkDotNet.Attributes;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class BubbleSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            for (var i = 0; i < listOfNumbers.Length; i++)
            {
                for (var j = 0; j < listOfNumbers.Length - 1; j++)
                {
                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        var tmp = listOfNumbers[j];
                        listOfNumbers[j] = listOfNumbers[j + 1];
                        listOfNumbers[j + 1] = tmp;
                    }
                }
            }

            return listOfNumbers;
        }

        [Benchmark]
        [Arguments(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public int[] SecondTry(int[] listOfNumbers)
        {
            for (var i = listOfNumbers.Length - 1; i > 1; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        var tmp = listOfNumbers[j];
                        listOfNumbers[j] = listOfNumbers[j + 1];
                        listOfNumbers[j + 1] = tmp;
                    }
                }
            }

            return listOfNumbers;
        }

        [Benchmark]
        [Arguments(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public int[] ThirdTry(int[] listOfNumbers)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (int i = 0; i < listOfNumbers.Length - 1; i++)
                {
                    if (listOfNumbers[i] > listOfNumbers[i + 1])
                    {
                        var tmp = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[i + 1];
                        listOfNumbers[i + 1] = tmp;

                        swapped = true;
                    }
                }

            } while (swapped == true);

            return listOfNumbers;
        }
    }
}