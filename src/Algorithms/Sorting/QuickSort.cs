using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class QuickSort
    {
        public int[] FirstTry(int[] listOfNumbers)
        {
            return Quick(listOfNumbers, 0, listOfNumbers.Length - 1);
        }

        public int[] Quick(int[] listOfNumbers, int left, int right)
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

                Quick(listOfNumbers, left, rightPointer - 1);
                Quick(listOfNumbers, rightPointer + 1, right);
            }

            return listOfNumbers;
        }
    }
}