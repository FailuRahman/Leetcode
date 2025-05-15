public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int k = m;
     for(int i = 0; i <n; i++){
        nums1[k] = nums2[i];
        k++;
     }
     Array.Sort(nums1);
    }
}