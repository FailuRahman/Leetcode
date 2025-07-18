public class Solution {
    public int NumberOfSpecialChars(string word) {
        HashSet<char> lower = new HashSet<char>();
        HashSet<char> upper = new HashSet<char>();

        foreach (char ch in word) {
            if (char.IsLower(ch))
                lower.Add(ch);
            else if (char.IsUpper(ch))
                upper.Add(char.ToLower(ch)); 
        }

        int count = 0;
        foreach (char ch in lower) {
            if (upper.Contains(ch)) {
                count++;
            }
        }

        return count;
    }
}
