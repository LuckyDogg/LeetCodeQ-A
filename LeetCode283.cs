using System;
public class solution{
    public void MoveZeros(int[] nums){
        int j=0;
        for (int i=0;i<nums.Length;i++){
            nums[i-j]=nums[i];
            if(nums[i]==0){
                j++;
            }
        }
        for(int i=0;i<j;i++){
            nums[nums.Length-1-i]=0;
        }
        
    }
    
}