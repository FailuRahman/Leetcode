public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        
        int len = nums.Length;
        int[] result = new int[len];

        int evenindex = 0;
        int oddindex = 1;

        foreach (int num in nums) {
            if (num % 2 ==0) {
                result[evenindex] = num;
                evenindex += 2;
            } else {
                result[oddindex] = num;
                oddindex += 2;
            }
        }
        return result;

    }
}