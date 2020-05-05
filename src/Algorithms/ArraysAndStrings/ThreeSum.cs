using Algorithms.Sorting;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class ThreeSum
    {
        [Benchmark(Baseline = true)]
        [Arguments(new int[] { 30, -40, -20, -10, 40, 0, 10, 5 })]
        public List<int[]> FirstTry(int[] nums)
        {
            var list = new List<int[]>();

            if (nums == null || nums.Length < 3)
                return list;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                            list.Add(new int[] { nums[i], nums[j], nums[k] });
                    }
                }
            }

            return list;
        }

        [Benchmark]
        [Arguments(new int[] { 30, -40, -20, -10, 40, 0, 10, 5 })]
        public List<int[]> SecondTry(int[] nums)
        {
            var list = new List<int[]>();

            if (nums == null || nums.Length < 3)
                return list;

            nums = new BubbleSort().ThirdTry(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int valueToSearchFor = nums[i] + nums[j];

                    int lowIndex = 0;
                    int highIndex = nums.Length - 1;

                    if (valueToSearchFor >= nums[lowIndex] && valueToSearchFor < nums[highIndex])
                    {
                        while (lowIndex <= highIndex)
                        {
                            int midIndex = (lowIndex + highIndex) / 2;
                            if (valueToSearchFor > nums[midIndex])
                                lowIndex = midIndex + 1;
                            else if (valueToSearchFor < nums[midIndex])
                                highIndex = midIndex - 1;
                            else
                                list.Add(new int[] { nums[i], nums[j], valueToSearchFor });
                        }
                    }
                }
            }

            return list;
        }
    }
}