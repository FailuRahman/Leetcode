public class Solution {
    public int ThirdMax(int[] nums) {
     var thirddis= nums.Distinct().OrderByDescending(n=> n).ToList();


       return thirddis.Count >= 3?thirddis[2]:thirddis[0];
    }
}