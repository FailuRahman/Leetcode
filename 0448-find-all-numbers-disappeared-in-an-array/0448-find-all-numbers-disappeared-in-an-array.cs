public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> arr=new List<int>();
        for(int i=1;i<=nums.Length;i++){
            arr.Add(i);
        }
        var res=arr.Except(nums).ToList();
        return res;
    }
}