public class Solution {
    public int MinOperations(int[] nums, int k) {
        
       
        HashSet<int> GreaterThank = new HashSet<int>();
        foreach(var num in nums)
        {
            if(num < k)
                return -1;
            if(num > k)
             GreaterThank.Add(num);
        }

        return GreaterThank.Count();



    }
}