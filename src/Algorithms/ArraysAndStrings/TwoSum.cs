using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class TwoSum
    {
        //Time: O(n^2)
        //Space: O(1)
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 0, 1, 2, 7, 11, 15 }, 9)]
        public int[] FirstTry(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return null;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                        return new int[] { i, j };
                }
            }

            return null;
        }

        //Time: O(n)
        //Space: O(1)
        [Benchmark]
        [Arguments(new int[] { 0, 1, 2, 7, 11, 15 }, 9)]
        public int[] SecondTry(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return null;

            int i = 0, j = 1;

            while (true)
            {
                int sum = nums[i] + nums[j];

                if (sum == target)
                    return new int[] { i, j };
                else if (j == nums.Length - 1)
                {
                    i++;
                    j = i + 1;
                }
                else
                    j++;

                if (i == nums.Length - 1)
                    break;
            }

            return null;
        }

        //Time: O(n)
        //Space: O(n)
        [Benchmark]
        [Arguments(new int[] { 0, 1, 2, 7, 11, 15 }, 9)]
        public int[] ThirdTry(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return null;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff) && map[diff] != i)
                    return new int[] { map[diff], i };
                else
                    map.Add(nums[i], i);
            }

            return null;
        }
    }
}