using BenchmarkDotNet.Validators;

namespace Algorithms.Sorting
{
    public class HeapSort
    {
        public int[] FirstTry(int[] values)
        {
            //6, 4, 9, 2, 1, 5, 7, 3, 8
            //         6
            //        /  \
            //       4    9
            //      / \  / \
            //     2   1 5  7
            //    / \
            //   3   8

            int size = values.Length;
            while (size > 0)
            {
                for (int i = size / 2; i >= 0; i--)
                {
                    int left = (i * 2) + 1;
                    if (left < size && values[left] > values[i])
                    {
                        swap(values, i, left);
                    }

                    int right = (i * 2) + 2;
                    if (right < size && values[right] > values[i])
                    {
                        swap(values, i, right);
                    }
                }

                swap(values, 0, size - 1);
                size--;
            }

            return values;
        }

        private void swap(int[] values, int i, int j)
        {
            int tmp = values[i];
            values[i] = values[j];
            values[j] = tmp;
        }
    }
}