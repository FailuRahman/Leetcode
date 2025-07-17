public class Solution {
    public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f) {
        if ((a == e || b == f) && !IsBetween(a, b, c, d, e, f))
            return 1;

        if (Math.Abs(c - e) == Math.Abs(d - f) && !IsBetweenDiagonal(c, d, a, b, e, f))
            return 1;

        return 2;
    }

    private bool IsBetween(int ax, int ay, int bx, int by, int cx, int cy) {
        if (ax == cx && ax == bx) {
            return (by > Math.Min(ay, cy) && by < Math.Max(ay, cy));
        }
        if (ay == cy && ay == by) {
            return (bx > Math.Min(ax, cx) && bx < Math.Max(ax, cx));
        }
        return false;
    }

    private bool IsBetweenDiagonal(int ax, int ay, int bx, int by, int cx, int cy) {
        if (Math.Abs(ax - cx) != Math.Abs(ay - cy)) return false;
        if (Math.Abs(bx - ax) != Math.Abs(by - ay)) return false;

        int dx = (cx - ax) > 0 ? 1 : -1;
        int dy = (cy - ay) > 0 ? 1 : -1;

        int x = ax + dx, y = ay + dy;
        while (x != cx && y != cy) {
            if (x == bx && y == by)
                return true;
            x += dx;
            y += dy;
        }
        return false;
    }
}
