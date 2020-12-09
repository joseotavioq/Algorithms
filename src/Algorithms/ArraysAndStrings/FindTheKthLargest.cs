using Algorithms.Queues;

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

            System.Array.Sort(nums);

            return nums[nums.Length - k];
        }

        public int SecondTry(int[] nums, int k)
        {
            if (nums == null || nums.Length < k)
            {
                return -1;
            }

            PriorityQueue priorityQueue = new PriorityQueue();
            for (int i = 0; i < nums.Length; i++)
            {
                priorityQueue.Add(nums[i]);
            }

            return priorityQueue.Peek(k);
        }
    }
}