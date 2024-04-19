
package heapOrPriorityQueue7;

import java.util.PriorityQueue;

//Time complexity O(nlogk) where n is the number o the element of the array and k is the max limit 
//Space complexity O(k);
public class KthLargestElementIinAnArray {
     public int findKthLargest(int[] nums, int k) {
         PriorityQueue<Integer> pq = new PriorityQueue<>();
         for(int i=0 ; i<nums.length ; i++){
             pq.offer(nums[i]);
             if(pq.size()>k){
                 pq.poll();
             }
         }
         return pq.poll();
     }
     public static void main(String[] args) {
        KthLargestElementIinAnArray obj = new KthLargestElementIinAnArray();
         int[]  nums = {3,2,3,1,2,4,5,5,6};
          int k = 4;
          System.out.println(obj.findKthLargest(nums, k));
    }
}
