public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        foreach(char let in letters){
            if(let > target)
            return let;
        }
        return letters[0];
    }
}