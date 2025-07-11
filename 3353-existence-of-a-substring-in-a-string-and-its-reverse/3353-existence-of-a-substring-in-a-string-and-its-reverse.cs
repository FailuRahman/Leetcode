public class Solution {
    public bool IsSubstringPresent(string s) {
        string reversed = new string(s.Reverse().ToArray());

        for (int i = 0; i < s.Length - 1; i++) {

            string sub = s.Substring(i, 2);

            if (reversed.Contains(sub)) {
                  return true;
            }
        }

        return false;
    }
}
