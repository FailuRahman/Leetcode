public class Solution
{
    public int Reverse(int x)
    {
        int reversed = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;    
            x = x / 10;               

           
            if (reversed > 214748364 || (reversed == 214748364 && lastDigit > 7))
                return 0;
            if (reversed < -214748364 || (reversed == -214748364 &&        lastDigit < -8))
                return 0;

            reversed = reversed * 10 + lastDigit;  
        }

        return reversed;
    }
}
