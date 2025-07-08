public class Solution {
    public bool CheckString(string s) {
        bool foundB = false;
        foreach (char c in s) {
            if (c == 'b') {
                
                foundB = true;
            } else if (foundB && c == 'a') {
                return false; 
            }
        }
        return true;
    }
}
