public class Solution {
    public int SingleNumber(int[] nums) {
     
        int res = 0;
      for(int i = 0; i<nums.Length; i++){
        
           int count =0;
        for(int j = 0; j<nums.Length; j++){
            if(nums[i] == nums[j]){
                count++;
            }

        }
        
        if(count ==1){
            res = nums[i];
            break;
        }


      }
      return res;
    }
}
