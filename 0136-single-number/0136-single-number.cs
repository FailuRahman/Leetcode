public class Solution {
    public int SingleNumber(int[] nums) {
    return nums
        .GroupBy(g=>g)
        .Where(c=>c.Count()==1)
        .Select(s=>s.Key)
        .FirstOrDefault();
       
    }
}