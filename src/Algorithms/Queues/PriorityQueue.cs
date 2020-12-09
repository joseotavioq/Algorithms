using Algorithms.Sorting;
using System.Collections.Generic;

namespace Algorithms.Queues
{
    public class PriorityQueue
    {
        private readonly List<int> data = new List<int>();

        public int Peek()
        {
            if (data.Count == 0)
                return -1;

            return data[0];
        }

        public int Peek(int k)
        {
            return data[k - 1];
        }

        public void Add(int item)
        {
            data.Add(item);

            //Heap sort
            int size = data.Count;
            while (size > 0)
            {
                for (int i = size / 2; i >= 0; i--)
                {
                    int left = (i * 2) + 1;
                    if (left < size && data[left] < data[i])
                    {
                        swap(i, left);
                    }

                    int right = (i * 2) + 2;
                    if (right < size && data[right] < data[i])
                    {
                        swap(i, right);
                    }
                }

                swap(0, size - 1);
                size--;
            }
        }

        private void swap(int i, int j)
        {
            int tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
        }
    }
}