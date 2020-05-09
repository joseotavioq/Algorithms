using BenchmarkDotNet.Attributes;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class QuickSort
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public int[] FirstTry(int[] listOfNumbers)
        {
            FirstQuick(listOfNumbers, 0, listOfNumbers.Length - 1);
            return listOfNumbers;
        }

        public void FirstQuick(int[] listOfNumbers, int left, int right)
        {
            if (left < right)
            {
                var pivot = listOfNumbers[left];
                var leftPointer = left + 1;
                var rightPointer = right;

                while (leftPointer <= rightPointer)
                {
                    if (listOfNumbers[leftPointer] <= pivot)
                        leftPointer++;
                    else if (pivot < listOfNumbers[rightPointer])
                        rightPointer--;
                    else
                    {
                        var tmp = listOfNumbers[leftPointer];
                        listOfNumbers[leftPointer] = listOfNumbers[rightPointer];
                        listOfNumbers[rightPointer] = tmp;
                        leftPointer++;
                        rightPointer--;
                    }
                }

                listOfNumbers[left] = listOfNumbers[rightPointer];
                listOfNumbers[rightPointer] = pivot;

                FirstQuick(listOfNumbers, left, rightPointer - 1);
                FirstQuick(listOfNumbers, rightPointer + 1, right);
            }
        }
    }
}