public class Solution {
    public int FindComplement(int num) {
     

            string binary = Convert.ToString(num,2); 
      
            
            string flipped = "";

            foreach (var c in binary)
            {
                flipped += (c == '1') ? '0' : '1'; 
                   
            }
            int number = Convert.ToInt32(flipped,2);
         
        

        return number;
    }
}