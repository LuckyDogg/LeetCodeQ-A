using System;
public class Solution{
    public int  SearchInsert(int[] nums,int target){
        if(target<nums[0])
            return 0;
        for(int i=1;i<nums.Length;i++){
            if(target>nums[i-1]&&target<nums[i])
                return  i; 
            if(target==nums[i-1]){
                return i-1;
            }              
        }
        return nums.Length;
    }
}