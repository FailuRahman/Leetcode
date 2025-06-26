public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        if (start > destination) {
            int temp = start;
            start = destination;
            destination = temp;
        }

        int total = 0;
        int clockwise = 0;

        for (int i = 0; i < distance.Length; i++) {
            total += distance[i];
            if (i >= start && i < destination) {
                clockwise += distance[i];
            }
        }

        return Math.Min(clockwise, total - clockwise);
    }
}
