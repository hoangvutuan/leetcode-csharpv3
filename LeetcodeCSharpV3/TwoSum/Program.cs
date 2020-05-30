using System;

namespace TwoSum
{
    class MainClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            /*
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i< nums.Length; i++) {
                int tmp = target - nums[i];
                if (map.ContainsKey(tmp)) {
                    return new int[]{map[tmp], i};
                } else {
                    if (!map.ContainsKey(nums[i]))
                        map.Add(nums[i], i);
                }
            }
            return null;
            */
            Array.Sort(nums);
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                if (nums[l] + nums[r] == target)
                {
                    return new int[] { l, r };
                }
                else if (nums[l] + nums[r] < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return new int[] { };
        }
        public static void Main(string[] args)
        {
            int[] nums = new int[] {3, 2, 4};
            int target = 6;
            int[] res = TwoSum(nums, target);
            foreach (int num in res) {
                Console.WriteLine(num);
            }
            
        }
    }
}
