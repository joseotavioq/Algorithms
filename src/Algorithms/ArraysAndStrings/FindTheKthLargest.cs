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
    }
}