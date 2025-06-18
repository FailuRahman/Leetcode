public class Solution {
    public bool RotateString(string s, string goal) {
        
        if(s.Length != goal.Length) return false;

        string combine = s +s;
         return combine.Contains(goal);

    }
}