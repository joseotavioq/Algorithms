using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    public class CandyCrush
    {
        public void FirstTry(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return;
            }

            int lastNumber = -1;
            int countOfEquals = 1;
            int i = 0;
            int lastBeforeRemoved = 0;
            bool elementsRemoved = false;
            while (i < numbers.Count)
            {
                if (numbers[i] == lastNumber)
                {
                    if (countOfEquals == 1)
                    {
                        lastBeforeRemoved = i - 2;
                    }

                    countOfEquals++;
                }
                else if (countOfEquals > 1)
                {
                    if (countOfEquals >= 3)
                    {
                        RemoveElements(numbers, countOfEquals, i);

                        i = lastBeforeRemoved;
                        while (i > 0 && numbers[i] == numbers[i - 1])
                        {
                            i--;
                        }

                        elementsRemoved = true;
                    }

                    countOfEquals = 1;
                    lastNumber = -1;
                }

                if (!elementsRemoved)
                {
                    lastNumber = numbers[i];
                    i++;
                }
                else
                {
                    elementsRemoved = false;
                }
            }

            if (countOfEquals >= 3)
            {
                RemoveElements(numbers, countOfEquals, i);
            }
        }

        private void RemoveElements(List<int> numbers, int countOfEquals, int i)
        {
            for (int j = i - 1; j >= i - countOfEquals; j--)
            {
                numbers.RemoveAt(j);
            }
        }
    }
}