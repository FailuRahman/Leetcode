public class Solution {
    public int MostFrequentEven(int[] nums) {
        var res = new Dictionary<int,int>();

        foreach(var item in nums){
            if(item%2==0){
                if(!res.ContainsKey(item)){
                    res[item]=0;
                }
                res[item]++;
            }
           
        }
         if(res.Count==0) return -1;
       
       return res.OrderByDescending(x=>x.Value).
       ThenBy(x=>x.Key)
       .First().Key;
    }
}