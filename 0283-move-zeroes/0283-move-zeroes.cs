public class Solution {
    public void MoveZeroes(int[] nums) {
         int nonZero = 0;

        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nonZero] = nums[i];
                nonZero++;
            }
        }
        for (int i = nonZero; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}