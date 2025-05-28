public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int res =0;
        int maxwealth = 0;
        foreach(var item in accounts){
      
            res = item.Sum();
            if(res > maxwealth){
                maxwealth = res;
            }
        }
        return maxwealth;
    }
}