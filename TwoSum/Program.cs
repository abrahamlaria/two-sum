using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            //----Implementation 1: Brute force. Time complexity: O(n^2). Space comlexity: O(1)

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    for (var j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[j] == target - nums[i])
            //        {
            //            return new[] { i, j };                      
            //        }
            //    }
            //}
            //throw new ArgumentException("No two sum solution");

            //-----Implementation 2: Dictionary (Two Pass). Time complexity: O(n). Space complexity: O(n) -> extra space required by the dictionary. Here we trade space by speed.

            //Dictionary<int, int> dict = new Dictionary<int, int>();

            //for(var i = 0; i < nums.Length; i++)
            //{
            //    //dict[nums[i]] = i; //Same as using the Add method but with some differences regarding duplicated keys. 
            //    //If trying to add a duplicated key using indexing it will replace the existing key with the new one. Trying to do the same using Add will throw an Argument exception.

            //    dict.Add(nums[i], i);
            //}

            //for(var i = 0; i < nums.Length; i++)
            //{
            //    var complement = target - nums[i];
            //    var test = dict[complement];
            //    if (dict.ContainsKey(complement) && dict[complement] != i)
            //    {
            //        return new[] { i, dict[complement] };
            //    }

            //}
            //throw new ArgumentException("No two sum solution");

            //-----Implementation 3: Dictionary (One Pass). Time complexity: O(n). Space complexity: O(n) -> extra space required by the dictionary. Here we trade space by speed.

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.ContainsKey(complement))
                { 
                    return new[] {dict[complement], i};
                }
                dict.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
        static void Main(string[] args)
        {
            int[] nums = {2, 11, 15, 7};
            const int target = 9;
            TwoSum(nums, target);
            Console.ReadLine();
        }
    }
}
