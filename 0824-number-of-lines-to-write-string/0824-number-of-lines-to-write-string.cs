public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int lines = 1;
        int currentWidth = 0;

        foreach (char c in s)
        {
            int width = widths[c - 'a'];
            if (currentWidth + width > 100)
            {
                lines++;
                currentWidth = width;
            }
            else
            {
                currentWidth += width;
            }
        }

        return new int[] { lines, currentWidth };
    }
}
