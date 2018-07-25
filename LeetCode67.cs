using System;
namespace LeetCode67{
public class Solution {
    public string AddBinary(string a, string b) {
        int One =Convert.ToInt32(b,2);
        int Two=Convert.ToInt32(a,2);
        int Temp=One+Two;
        return Convert.ToString(Temp,2);
    }
}
}