public class Solution {
    public int ThirdMax(int[] nums) {
        
        var distinct = nums.Distinct().OrderByDescending(n=>n).ToList();
        if(distinct.Count >= 3){
            return distinct[2];
        }else{
            return distinct[0];
        }
    }
}