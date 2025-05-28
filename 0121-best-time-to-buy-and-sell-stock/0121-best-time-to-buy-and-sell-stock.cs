public class Solution {
    public int MaxProfit(int[] prices) {

        int minValue = int.MaxValue;
        int maxProf = 0;

        foreach(var price in prices){
            if(price < minValue){
                minValue = price;
            }else if(price - minValue > maxProf){
                maxProf = price - minValue;
            }
        }
        return  maxProf;
    }
}