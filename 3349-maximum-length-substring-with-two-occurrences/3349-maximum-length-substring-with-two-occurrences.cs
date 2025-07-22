public class Solution {
    public int MaximumLengthSubstring(string s) {

        int maxLength = 0;
        int left = 0;

        
    Dictionary<char, int> charCount = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];
            if (!charCount.ContainsKey(c))
                charCount[c] = 0;
            charCount[c]++;

            while (charCount[c] > 2) {
                charCount[s[left]]--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
