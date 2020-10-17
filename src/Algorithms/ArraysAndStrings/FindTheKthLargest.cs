using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    public class FindTheKthLargest
    {
        public int FirstTry(int[] nums, int k)
        {
            if (nums == null || nums.Length < k)
            {
                return -1;
            }

            int i = 0;
            while (i < nums.Length - k)
            {
                i = SeparateLessThanPivot(nums, i);
            }

            return nums[nums.Length - k];
        }

        private int SeparateLessThanPivot(int[] nums, int i)
        {
            int j = i;
            int pivot = nums.Length - 1;

            while (j < pivot)
            {
                if (nums[j] < nums[pivot])
                {
                    swap(nums, i, j);
                    i++;
                }
                j++;
            }

            swap(nums, i, pivot);
            return i;
        }

        private void swap(int[] values, int i, int j)
        {
            if (i != j)
            {
                int tmp = values[i];
                values[i] = values[j];
                values[j] = tmp;
            }
        }
    }
}