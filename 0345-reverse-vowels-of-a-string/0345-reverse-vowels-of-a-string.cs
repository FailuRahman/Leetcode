public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new List<char>();
        
    
        foreach (char c in s) {
            if ("aeiouAEIOU".Contains(c)) {
                vowels.Add(c);
            }
        }

      
        int vowelIndex = vowels.Count - 1;
        char[] result = s.ToCharArray();

        for (int i = 0; i < result.Length; i++) {
            if ("aeiouAEIOU".Contains(result[i])) {
                result[i] = vowels[vowelIndex--];
            }
        }

        return new string(result);
    }
}
