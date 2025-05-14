public class Solution {
    public string AddStrings(string num1, string num2) {
      BigInteger n1 = BigInteger.Parse(num1);
      BigInteger n2 = BigInteger.Parse(num2);

        BigInteger sum = n1 + n2;
        return sum.ToString();
    }
}