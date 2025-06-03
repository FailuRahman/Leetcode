public class Solution {
    public int[] SortedSquares(int[] nums) {

       int n = nums.Length;
       int[] result = new int[n];
       for(int i =0; i <nums.Length; i++){
        result[i] = nums[i] * nums[i];
       }
       Array.Sort(result);
       return result;

       
        
    }
}