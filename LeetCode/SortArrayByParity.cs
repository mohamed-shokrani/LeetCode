﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
  
    public static class SortArrayByParity
    {
        public static int[] SortArrayByParityF(int[] array)
        {
            List<int> list = [.. array];
            List<int> orderedList =list.OrderBy(x => x % 2 !=0).ToList();
            int[] arr = [.. orderedList];

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }
}
//Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
//        =
//Return any array that satisfies this condition.

//Example 1:

//Input: nums = [3, 1, 2, 4]
//Output: [2,4,3,1]
//Explanation: The outputs[4, 2, 3, 1], [2, 4, 1, 3], and[4, 2, 1, 3] would also be accepted.
//Example 2:

//Input: nums = [0]
//Output: [0]


//Constraints:

//1 <= nums.length <= 5000
//0 <= nums[i] <= 5000