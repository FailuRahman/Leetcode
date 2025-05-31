public class Solution {
    public bool IsPerfectSquare(int num) {
        
        if(num<0) return false;

        double sqr = Math.Sqrt(num);
        if(sqr % 1 != 0){
            return false;
        }
        return true;
    }
}