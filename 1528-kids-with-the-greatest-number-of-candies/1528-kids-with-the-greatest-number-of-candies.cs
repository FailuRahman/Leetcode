public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = candies.Max();  

        List<bool> result = new List<bool>();

        foreach (int c in candies) {
            result.Add(c + extraCandies >= max);
        }

        return result;
    }
}
