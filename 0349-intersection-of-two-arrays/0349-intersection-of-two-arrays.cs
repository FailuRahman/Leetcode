public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var ans = nums1.Intersect(nums2).ToArray();
        return ans;
    }
}