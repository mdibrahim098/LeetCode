package heapOrPriorityQueue7;

import java.util.Arrays;
import java.util.Comparator;
import java.util.PriorityQueue;
//Time complexity O(nlogk); where n is the number of array element and k is the minimum closest element
//Time complexity O(k);
public class KClosestPointsToOrigin {

    public int[][] kClosest(int[][] points, int k) {
        PriorityQueue<int[]> pq = new PriorityQueue<>(new Comparator<int[]>() {
            @Override
            public int compare(int[] a, int[] b) {
                return Integer.compare(b[0] * b[0] + b[1] * b[1],
                        a[0] * a[0] + a[1] * a[1]);
            }

        }); // by default min heap
        for (int[] point : points) {
            pq.offer(point);
            if (pq.size() > k) {
                pq.poll();
            }

        }
        int[][] result = new int[k][2];
        for (int i = 0; i < k; i++) {
            int[] cur = pq.poll();
            result[i][0] = cur[0];
            result[i][1] = cur[1];
        }
        return result;
    }

    public static void main(String[] args) {
        KClosestPointsToOrigin obj = new KClosestPointsToOrigin();
        int[][] points = {{3, 3}, {5, -1}, {-2, 4}};
        int k = 2;
        System.out.println(Arrays.deepToString(obj.kClosest(points, k)));
    }
}
