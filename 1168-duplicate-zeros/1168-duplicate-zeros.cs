public class Solution {
    public void DuplicateZeros(int[] arr) {
        List<int> temp = new List<int>();

        foreach (int num in arr) {
            temp.Add(num);
            if (num == 0) {
                temp.Add(0); 
            }
        }

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = temp[i];
        }
    }
}
