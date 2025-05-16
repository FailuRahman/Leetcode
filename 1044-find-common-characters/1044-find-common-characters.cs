public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] minFreq = new int[26];
        Array.Fill(minFreq, int.MaxValue);

        foreach (var word in words) {
            int[] freq = new int[26];
            foreach (char c in word) {
                freq[c - 'a']++;
            }

            for (int i = 0; i < 26; i++) {
                minFreq[i] = Math.Min(minFreq[i], freq[i]);
            }
        }

        List<string> result = new List<string>();
        for (int i = 0; i < 26; i++) {
            for (int j = 0; j < minFreq[i]; j++) {
                result.Add(((char)(i + 'a')).ToString());
            }
        }

        return result;
    }
}
