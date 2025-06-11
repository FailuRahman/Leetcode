public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;

        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0) {
                string pattern = s.Substring(0, i);
                string repeated = string.Concat(Enumerable.Repeat(pattern, n / i));

                if (repeated == s)
                    return true;
            }
        }

        return false;
    }
}
