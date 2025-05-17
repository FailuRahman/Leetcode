public class Solution {
    public int AddDigits(int num) {
    
        while (num >= 10)  
        {
         num= num.ToString()
                     .Select(c => int.Parse(c.ToString())).Sum();
        }
        return num;
    }
}
