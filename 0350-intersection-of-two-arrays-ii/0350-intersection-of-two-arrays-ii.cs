public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
    
       var dic = new Dictionary<int,int>();
       var result = new List<int>();
         foreach(var num in nums1){
            dic[num] =dic.ContainsKey(num) ? dic[num] +1:1;
        
         }
         foreach(var num in nums2){
            if(dic.ContainsKey(num)&& dic[num] > 0){
                result.Add(num);
                dic[num]--;
            }
         }

         return result.ToArray();

    }
}