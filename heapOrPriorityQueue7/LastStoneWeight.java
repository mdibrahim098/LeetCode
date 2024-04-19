package heapOrPriorityQueue7;

import java.util.Collections;
import java.util.PriorityQueue;
//Time complexity O(nlogn) // queue every element push and a poll() time logn
//Space complexity O(n)
//where n is the number of the element of the array
public class LastStoneWeight {

    public int lastStoneWeight(int[] stones) {

        PriorityQueue<Integer> pq = new PriorityQueue<>(Collections.reverseOrder());
        for (int stone : stones) {
            pq.offer(stone);
        }

        while (pq.size() > 1) {
            int x = pq.poll();
            int y = pq.poll();

            pq.offer(x - y);

        }
        if (pq.size() == 0) {
            return 0;
        }
        return pq.poll();
    }

    public static void main(String[] args) {
        LastStoneWeight obj = new LastStoneWeight();
        int[] stones = {2, 7, 4, 1, 8, 1};
        System.out.println(obj.lastStoneWeight(stones));
    }
}
