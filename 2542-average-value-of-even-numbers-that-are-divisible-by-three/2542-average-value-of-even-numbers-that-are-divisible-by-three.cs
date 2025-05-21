public class Solution {
    public int AverageValue(int[] nums) {

       int count = 0;
       int sum = 0;
        foreach(int num in nums){
            if(num % 6 == 0){
                sum += num;
                count++;
            }
        }
        return count > 0 ? (int)Math.Floor((double)sum/count) : 0 ;
        
    }
}