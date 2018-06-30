using System;
namespace LeetCode167{
    public class Solution{
        public int[] TwoSum(int[] numbers,int target){
            
            int[] result = new int[2];
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                int temp = numbers[left] + numbers[right];
                if (temp == target)
                {
                    result[0] = left + 1;
                    result[1] = right + 1;
                    break;
                }
                if (temp > target)
                    right--;
                else
                    left++;
            }
            return result;
    }
}
}