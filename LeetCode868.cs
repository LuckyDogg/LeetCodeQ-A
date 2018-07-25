using System;
namespace LeetCode868{
    public class Solution{
        public  int[][] Tranpose(int[][] A){
            int[][] Temp=new int[A[0].Length][];
            for(int i=0;i<A[0].Length;i++){
                for(int j=0;j<(A.Length);j++){
                    Temp[i][j]=A[j][i];
                }
            }
            return Temp;      
        }
    }
}