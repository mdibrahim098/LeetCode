
package heapOrPriorityQueue7;

import java.util.PriorityQueue;

// time complexity O(nlogk)
//n is the number of elements in nums array, and each element add in priority queue needs logk time
// space complexity O(k)

class KthLargest {
 PriorityQueue<Integer> pq = new PriorityQueue<>();
 int size;
    public KthLargest(int k, int[] nums) {
        this.size = k;
        for(int num : nums){
            pq.offer(num);
            if(pq.size()>k){
                pq.poll();
            }
        }
    }
    
    public int add(int val) {
        pq.offer(val);
        if(pq.size()>size){
            pq.poll();
        }
        return pq.peek();
    }
}

public class KthLargestElementInAStream {
    public static void main(String[] args) {
        int k =3;
        int [] nums = {4, 5, 8, 2};
        KthLargest obj = new KthLargest(k , nums);
        int [] ins  = {3,5,10,9,4};
        for(int in : ins){
             System.out.print(obj.add(in)+ " ");
        }
        System.out.println("");
        
    }
}