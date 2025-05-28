public class Solution {
    public bool IsThree(int n) {
      int count = 0;

      for( var i = 1; i<=n; i++){
        if(n % i==0){
            count ++;
            
        }
      }

    return count ==3;
        
    }
}