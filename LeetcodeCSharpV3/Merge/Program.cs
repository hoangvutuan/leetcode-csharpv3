using System;

//leetcode 
namespace Merge
{
    class MainClass
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] res = new int[nums1.Length];
            int i = 0;
            int j = 0;
            int c = 0;
            while (i < m && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    res[c] = nums1[i];
                    c++;
                    i++;
                }
                else
                {
                    res[c] = nums2[j];
                    c++;
                    j++;
                }
            }
            /*
                Console.WriteLine("c = " + c);
                foreach (int  num in res) {
                    Console.WriteLine(num);
                }
                */
            while (i < m)
            {
                res[c++] = nums1[i++];
            }
            while (j < nums2.Length)
            {
                res[c++] = nums2[j++];
            }

            //  Array.Resize<byte>(ref array1, 20);
            //  Array.Resize<int>(ref nums1, res.Length);
            Array.Copy(res, 0, nums1, 0, c);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3
             */
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0};
            int[] nums2 = new int[] {2, 5, 6};
            int m = 3;
            Merge(nums1, m, nums2, nums2.Length);
            foreach (int num in nums1) {
                Console.WriteLine(num);
            }
        }
    }
}
